using System;
using System.Net;
using System.Windows.Forms;

namespace TelemetriaFH6
{
    public partial class FormPassword : Form
    {
        public string ResultPassword { get; private set; } = "";

        // URL do seu servidor Raw do GitHub
        private const string PasswordUrl = "https://raw.githubusercontent.com/MrGeeH/algo-/main/senha.txt";

        public FormPassword()
        {
            InitializeComponent();
            if (ConfigManager.Language == "EN")
            {
                this.Text = "Dev Authentication";
                lblPrompt.Text = "Enter Developer Password:";
                btnConfirm.Text = "AUTHENTICATE";
            }
        }

        private void FormPassword_Load(object sender, EventArgs e)
        {
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string typedPassword = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(typedPassword))
            {
                string vazioMsg = ConfigManager.Language == "EN" ? "Please enter a password." : "Por favor, digite uma senha.";
                MessageBox.Show(vazioMsg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnConfirm.Text = ConfigManager.Language == "EN" ? "CHECKING..." : "VERIFICANDO...";
            btnConfirm.Enabled = false;

            try
            {
                using (WebClient client = new WebClient())
                {
                    client.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);

                    // Baixa o texto e sanitiza caracteres invisíveis
                    string onlinePassword = client.DownloadString(PasswordUrl);
                    onlinePassword = onlinePassword.Replace("\r", "").Replace("\n", "");
                    onlinePassword = onlinePassword.Trim('\uFEFF', ' ', '\t');

                    // COMPARAÇÃO DIRETA E SILENCIOSA
                    if (typedPassword.Equals(onlinePassword, StringComparison.OrdinalIgnoreCase))
                    {
                        ResultPassword = typedPassword;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        string erroMsg = ConfigManager.Language == "EN" ? "Access Denied! Incorrect Password." : "Acesso Negado! Senha incorreta.";
                        MessageBox.Show(erroMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ResetButton();
                    }
                }
            }
            catch (Exception)
            {
                string netError = ConfigManager.Language == "EN" ?
                    "Failed to connect to authentication server. Check your internet connection." :
                    "Falha ao conectar ao servidor de autenticação. Verifique sua conexão com a internet.";

                MessageBox.Show(netError, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetButton();
            }
        }

        private void ResetButton()
        {
            btnConfirm.Enabled = true;
            btnConfirm.Text = ConfigManager.Language == "EN" ? "AUTHENTICATE" : "AUTENTICAR";
            txtPassword.Clear();
            txtPassword.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConfirm_Click(this, null);
            }
        }
    }
}