using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace TelemetriaFH6
{
    public partial class FormDevTest : Form
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct XINPUT_VIBRATION
        {
            public ushort wLeftMotorSpeed;
            public ushort wRightMotorSpeed;
        }

        [DllImport("xinput1_4.dll", EntryPoint = "XInputSetState")]
        public static extern int XInputSetState(int dwUserIndex, ref XINPUT_VIBRATION pVibration);

        // Componentes para injeção de pacotes UDP na rede local
        private System.Windows.Forms.Timer telemetryTimer;
        private bool isSimulating = false;

        public FormDevTest()
        {
            InitializeComponent();

            // Configura o clock do simulador para despachar dados a 60Hz (idêntico ao Forza)
            telemetryTimer = new System.Windows.Forms.Timer();
            telemetryTimer.Interval = 16; // ~16 milissegundos por ciclo
            telemetryTimer.Tick += TelemetryTimer_Tick;

            ApplyDevLanguage();
        }

        private void ApplyDevLanguage()
        {
            if (ConfigManager.Language == "EN")
            {
                this.Text = "Advanced Dev Diagnostic Station";
                lblDevTitle.Text = "DEV CONTROL PANEL - ADVANCED";
                grpVibration.Text = "Hardware Diagnostic Suite (XInput)";
                lblTrackLeft.Text = "Left Motor (Heavy / Terrain): 0%";
                lblTrackRight.Text = "Right Motor (High / RPM): 0%";
                btnTestVib.Text = "TEST HAPTIC PULSE";
                btnStopVib.Text = "Kill Motors";
                grpTelemetrySim.Text = "Forza FH6 Telemetry Spoofing Simulator (Loopback)";
                lblSimulateRPM.Text = "Force Simulated RPM Level:";
                btnToggleSim.Text = "START UDP DATA INJECTION";
            }
        }

        private void SetHardwareVibration(float leftIntensity, float rightIntensity)
        {
            XINPUT_VIBRATION vib = new XINPUT_VIBRATION();
            vib.wLeftMotorSpeed = (ushort)(leftIntensity * 65535);
            vib.wRightMotorSpeed = (ushort)(rightIntensity * 65535);
            XInputSetState(0, ref vib); // Alvo fixo no controle principal
        }

        private void trackVibration_Scroll(object sender, EventArgs e)
        {
            float left = trackLeftMotor.Value / 100f;
            float right = trackRightMotor.Value / 100f;

            if (ConfigManager.Language == "EN")
            {
                lblTrackLeft.Text = $"Left Motor (Heavy / Terrain): {trackLeftMotor.Value}%";
                lblTrackRight.Text = $"Right Motor (High / RPM): {trackRightMotor.Value}%";
            }
            else
            {
                lblTrackLeft.Text = $"Motor Esquerdo (Grave / Terreno): {trackLeftMotor.Value}%";
                lblTrackRight.Text = $"Motor Direito (Agudo / RPM): {trackRightMotor.Value}%";
            }

            SetHardwareVibration(left, right);
        }

        private void btnTestVib_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => {
                for (int i = 0; i < 3; i++)
                {
                    SetHardwareVibration(1.0f, 1.0f);
                    Thread.Sleep(50);
                    SetHardwareVibration(0.0f, 0.0f);
                    Thread.Sleep(50);
                }
            });
            t.Start();
        }

        private void btnStopVib_Click(object sender, EventArgs e)
        {
            trackLeftMotor.Value = 0;
            trackRightMotor.Value = 0;
            trackVibration_Scroll(this, null);
        }

        // --- SISTEMA SIMULADOR DE TELEMETRIA POR SOFTWARE ---
        private void btnToggleSim_Click(object sender, EventArgs e)
        {
            if (!isSimulating)
            {
                isSimulating = true;
                telemetryTimer.Start();

                btnToggleSim.Text = ConfigManager.Language == "EN" ? "STOP DATA INJECTION" : "PARAR INJEÇÃO DE DADOS";
                btnToggleSim.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            }
            else
            {
                StopSimulation();
            }
        }

        private void StopSimulation()
        {
            isSimulating = false;
            telemetryTimer.Stop();

            btnToggleSim.Text = ConfigManager.Language == "EN" ? "START UDP DATA INJECTION" : "INICIAR INJEÇÃO DE DADOS UDP";
            btnToggleSim.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
        }

        private void TelemetryTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                // Estrutura de vetor de Bytes exigida pelo motor de leitura do Form1 (Mínimo de 20 bytes)
                byte[] simulatedPacket = new byte[24];

                float maxRpm = 8000f; // Fixa uma rotação máxima padrão de simulação
                float currentRpm = (trackRPM.Value / 100f) * maxRpm;

                // Injeta os valores flutuantes (float/Single) nas posições exatas lidas pelo BitConverter
                Array.Copy(BitConverter.GetBytes(maxRpm), 0, simulatedPacket, 8, 4);      // Offset 8: MaxRPM
                Array.Copy(BitConverter.GetBytes(currentRpm), 0, simulatedPacket, 16, 4);  // Offset 16: CurrentRPM

                // Despacha o pacote via UDP Loopback para a porta local configurada no aplicativo
                using (UdpClient mockSender = new UdpClient())
                {
                    mockSender.Send(simulatedPacket, simulatedPacket.Length, "127.0.0.1", ConfigManager.Port);
                }
            }
            catch { }
        }

        private void trackRPM_Scroll(object sender, EventArgs e)
        {
            lblRpmVal.Text = $"{trackRPM.Value}%";
        }

        private void FormDevTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopSimulation();
            SetHardwareVibration(0.0f, 0.0f);
        }
    }
}