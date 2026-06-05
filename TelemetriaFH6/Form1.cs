using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace TelemetriaFH6
{
    public partial class Form1 : Form
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct XINPUT_VIBRATION
        {
            public ushort wLeftMotorSpeed;
            public ushort wRightMotorSpeed;
        }

        [DllImport("xinput1_4.dll", EntryPoint = "XInputSetState")]
        public static extern int XInputSetState(int dwUserIndex, ref XINPUT_VIBRATION pVibration);

        private Thread telemetryThread;
        private Thread vibrationThread;
        private UdpClient udpClient;
        private bool isRunning = false;

        private volatile float currentRpmPct = 0.0f;
        private int selectedSlot = 0;
        private float maxIntensityFactor = 1.0f;
        private int alertStyle = 0;

        public Form1()
        {
            InitializeComponent();
            ConfigManager.Load();

            txtPercentage.Text = (ConfigManager.TargetPercentage * 100).ToString();

            listBoxControllers.Items.Add("Controle 1 (Slot 0)");
            listBoxControllers.Items.Add("Controle 2 (Slot 1)");
            listBoxControllers.SelectedIndex = 0;

            ApplyLanguage();
        }

        private void ApplyLanguage()
        {
            int savedStyleIndex = cmbVibrationStyle.SelectedIndex;
            cmbVibrationStyle.Items.Clear();

            if (ConfigManager.Language == "EN")
            {
                this.Text = "FH6 Telemetry - MrGeH";
                opçõesToolStripMenuItem.Text = "Options";
                ajudaToolStripMenuItem.Text = "Help";
                chkShiftLight.Text = "Enable Tactile ShiftLight";
                chkReduceGameVibration.Text = "Terrain Filter (Reduced game vib)";
                lblIntensityTitle.Text = "Force %";
                lblStyleTitle.Text = "Alert Style";
                btnStart.Text = isRunning ? "Stop Telemetry" : "Start Listening";

                cmbVibrationStyle.Items.Add("Continuous");
                cmbVibrationStyle.Items.Add("Fast Pulse");
                cmbVibrationStyle.Items.Add("Long Pulse");
                cmbVibrationStyle.Items.Add("Ramp Up");

                if (!isRunning) lblStatus.Text = "Status: Waiting...";
                else lblStatus.Text = $"Listening: {ConfigManager.IP}:{ConfigManager.Port}";
            }
            else
            {
                this.Text = "Telemetria FH6 - MrGeH";
                opçõesToolStripMenuItem.Text = "Opções";
                ajudaToolStripMenuItem.Text = "Ajuda";
                chkShiftLight.Text = "Ativar ShiftLight Tátil";
                chkReduceGameVibration.Text = "Filtro Terreno (Vibração jogo reduzida)";
                lblIntensityTitle.Text = "Força %";
                lblStyleTitle.Text = "Estilo Alerta";
                btnStart.Text = isRunning ? "Parar Telemetria" : "Iniciar Escuta";

                cmbVibrationStyle.Items.Add("Contínuo");
                cmbVibrationStyle.Items.Add("Pulso Rápido");
                cmbVibrationStyle.Items.Add("Pulso Longo");
                cmbVibrationStyle.Items.Add("Crescente");

                if (!isRunning) lblStatus.Text = "Status: Aguardando...";
                else lblStatus.Text = $"Escutando: {ConfigManager.IP}:{ConfigManager.Port}";
            }

            cmbVibrationStyle.SelectedIndex = savedStyleIndex >= 0 ? savedStyleIndex : 0;
        }

        private void SetVibration(int id, float intensity)
        {
            XINPUT_VIBRATION vib = new XINPUT_VIBRATION();
            ushort val = (ushort)(intensity * 65535);
            vib.wLeftMotorSpeed = val;
            vib.wRightMotorSpeed = val;
            XInputSetState(id, ref vib);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                if (float.TryParse(txtPercentage.Text, out float userPct))
                {
                    ConfigManager.TargetPercentage = userPct / 100f;
                    ConfigManager.Save();
                }

                if (float.TryParse(txtIntensity.Text, out float userIntensity))
                {
                    maxIntensityFactor = userIntensity / 100f;
                    if (maxIntensityFactor > 1.0f) maxIntensityFactor = 1.0f;
                    if (maxIntensityFactor < 0.0f) maxIntensityFactor = 0.0f;
                }

                selectedSlot = listBoxControllers.SelectedIndex;
                alertStyle = cmbVibrationStyle.SelectedIndex;
                currentRpmPct = 0.0f;
                isRunning = true;

                btnStart.Text = ConfigManager.Language == "EN" ? "Stop Telemetry" : "Parar Telemetria";
                lblStatus.Text = ConfigManager.Language == "EN" ? $"Listening: {ConfigManager.IP}:{ConfigManager.Port}" : $"Escutando: {ConfigManager.IP}:{ConfigManager.Port}";

                // THREAD DE VIBRAÇÃO EM ALTA FREQUÊNCIA (BOMBARDEIO DE OVERWRITE)
                vibrationThread = new Thread(() =>
                {
                    while (isRunning)
                    {
                        if (chkShiftLight.Checked)
                        {
                            float target = ConfigManager.TargetPercentage;
                            int activeStyle = alertStyle;

                            // Se o filtro de terreno não estiver marcado, força o pulso longo para cortar o ruído do jogo
                            if (!chkReduceGameVibration.Checked && activeStyle == 0)
                            {
                                activeStyle = 2;
                            }

                            if (activeStyle == 3) // Modo Crescente (Rampa)
                            {
                                float startRamp = target - 0.05f;
                                if (currentRpmPct >= startRamp)
                                {
                                    float rampFactor = (currentRpmPct - startRamp) / (1.0f - startRamp);
                                    if (rampFactor > 1.0f) rampFactor = 1.0f;
                                    if (rampFactor < 0.1f) rampFactor = 0.1f;

                                    // Bombardeia em loop curto de 4ms para vencer o motor do Forza
                                    SetVibration(selectedSlot, rampFactor * maxIntensityFactor);
                                    Thread.Sleep(4);
                                }
                                else
                                {
                                    SetVibration(selectedSlot, 0.0f);
                                    Thread.Sleep(20);
                                }
                            }
                            else if (currentRpmPct >= target) // Se atingiu o limite de RPM
                            {
                                switch (activeStyle)
                                {
                                    case 0: // Contínuo Direto (Spam de 4ms focado em força bruta)
                                        SetVibration(selectedSlot, maxIntensityFactor);
                                        Thread.Sleep(4);
                                        break;

                                    case 1: // Pulso Rápido (Metralhadora Ritmicamente Controlada)
                                        for (int i = 0; i < 12; i++)
                                        { // Mantém ligado por ~48ms bombardeando
                                            SetVibration(selectedSlot, maxIntensityFactor);
                                            Thread.Sleep(4);
                                        }
                                        SetVibration(selectedSlot, 0.0f);
                                        Thread.Sleep(40); // Pausa do pulso
                                        break;

                                    case 2: // Pulso Longo (Alerta Estendido)
                                        for (int i = 0; i < 40; i++)
                                        { // Mantém ligado por ~160ms bombardeando
                                            SetVibration(selectedSlot, maxIntensityFactor);
                                            Thread.Sleep(4);
                                        }
                                        SetVibration(selectedSlot, 0.0f);
                                        Thread.Sleep(100); // Pausa do pulso
                                        break;
                                }
                            }
                            else
                            {
                                SetVibration(selectedSlot, 0.0f);
                                Thread.Sleep(20);
                            }
                        }
                        else
                        {
                            SetVibration(selectedSlot, 0.0f);
                            Thread.Sleep(100);
                        }
                    }
                    SetVibration(selectedSlot, 0.0f);
                });
                vibrationThread.Start();

                // THREAD DE TELEMETRIA ASSÍNCRONA E INDEPENDENTE
                telemetryThread = new Thread(() =>
                {
                    try
                    {
                        udpClient = new UdpClient(ConfigManager.Port);
                        IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);

                        while (isRunning)
                        {
                            try
                            {
                                byte[] data = udpClient.Receive(ref remoteEP);
                                if (data.Length >= 20)
                                {
                                    float maxRpm = BitConverter.ToSingle(data, 8);
                                    float currentRpm = BitConverter.ToSingle(data, 16);

                                    if (maxRpm > 0)
                                    {
                                        currentRpmPct = currentRpm / maxRpm;

                                        this.BeginInvoke((MethodInvoker)delegate {
                                            if (!isRunning) return;
                                            int progressValue = (int)(currentRpmPct * 100);
                                            progressBarRPM.Value = progressValue > 100 ? 100 : (progressValue < 0 ? 0 : progressValue);
                                        });
                                    }
                                }
                            }
                            catch (SocketException) { }
                            catch (ObjectDisposedException) { break; }
                        }
                    }
                    catch { }
                    finally
                    {
                        if (udpClient != null) udpClient.Close();
                    }
                });
                telemetryThread.Start();
            }
            else
            {
                StopTelemetry();
            }
        }

        private void StopTelemetry()
        {
            isRunning = false;
            currentRpmPct = 0.0f;
            if (udpClient != null) { try { udpClient.Close(); } catch { } }
            ApplyLanguage();
            progressBarRPM.Value = 0;
        }

        private void opçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOptions frmOpt = new FormOptions();
            frmOpt.ShowDialog();

            ApplyLanguage();

            if (isRunning) { StopTelemetry(); btnStart_Click(this, null); }
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp frmHelp = new FormHelp();
            frmHelp.ShowDialog();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            isRunning = false;
            if (udpClient != null) { try { udpClient.Close(); } catch { } }
            base.OnFormClosing(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
        }
    }
}