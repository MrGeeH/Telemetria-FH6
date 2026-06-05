using System;
using System.Windows.Forms;

namespace TelemetriaFH6
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();

            txtIP.Text = ConfigManager.IP;
            txtPort.Text = ConfigManager.Port.ToString();

            cmbLanguage.Items.Clear();
            cmbLanguage.Items.Add("Português (PTBR)");
            cmbLanguage.Items.Add("English (EN)");
            cmbLanguage.SelectedIndex = ConfigManager.Language == "PTBR" ? 0 : 1;

            ApplyOptionsLanguage();
        }

        private void ApplyOptionsLanguage()
        {
            if (ConfigManager.Language == "EN")
            {
                this.Text = "System Configuration";
                btnSave.Text = "Save Settings";
                label2.Text = "PORT:";
            }
            else
            {
                this.Text = "Configurações do Sistema";
                btnSave.Text = "Salvar Configurações";
                label2.Text = "PORTA:";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConfigManager.IP = txtIP.Text;
            ConfigManager.Port = int.Parse(txtPort.Text);
            ConfigManager.Language = cmbLanguage.SelectedIndex == 0 ? "PTBR" : "EN";
            ConfigManager.Save();

            string mensagemSucesso = ConfigManager.Language == "EN" ? "Configurations saved to MrGeH.config file successfully!" : "Configurações salvas no arquivo MrGeH.config!";
            string titulo = ConfigManager.Language == "EN" ? "Success" : "Sucesso";

            MessageBox.Show(mensagemSucesso, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        // CORREÇÃO DA VALIDAÇÃO DUPLICADA
        private void btnDev_Click(object sender, EventArgs e)
        {
            using (FormPassword frmPass = new FormPassword())
            {
                // Se o formulário retornou DialogResult.OK, significa que a senha digitada 
                // já bateu com o arquivo do GitHub com sucesso! Não precisamos re-checar aqui.
                if (frmPass.ShowDialog() == DialogResult.OK)
                {
                    this.Hide();
                    FormDevTest frmDev = new FormDevTest();
                    frmDev.ShowDialog();
                    this.Close();
                }
            }
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {
        }
    }
}