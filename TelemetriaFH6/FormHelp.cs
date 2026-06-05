using System;
using System.Windows.Forms;

namespace TelemetriaFH6
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
            ApplyHelpLanguage();
        }

        private void ApplyHelpLanguage()
        {
            if (ConfigManager.Language == "EN")
            {
                this.Text = "Help & Credits";
                lblTitle.Text = "NEED HELP?";
                lblDiscord.Text = "Contact me on Discord:";
                lblCredits.Text = "Credits: Developed by MrGeH";
                btnOk.Text = "CLOSE";
            }
            else
            {
                this.Text = "Ajuda & Créditos";
                lblTitle.Text = "PRECISA DE AJUDA?";
                lblDiscord.Text = "Contacte-me no Discord:";
                lblCredits.Text = "Créditos: Desenvolvido por MrGeH";
                btnOk.Text = "FECHAR";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o pop-up e retorna ao app principal
        }

        private void FormHelp_Load(object sender, EventArgs e)
        {
        }
    }
}