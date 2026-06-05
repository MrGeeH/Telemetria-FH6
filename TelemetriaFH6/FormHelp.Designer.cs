namespace TelemetriaFH6
{
    partial class FormHelp
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDiscord = new System.Windows.Forms.Label();
            this.lblDiscordTag = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(164, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PRECISA DE AJUDA?";
            // 
            // lblDiscord
            // 
            this.lblDiscord.AutoSize = true;
            this.lblDiscord.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDiscord.ForeColor = System.Drawing.Color.White;
            this.lblDiscord.Location = new System.Drawing.Point(21, 58);
            this.lblDiscord.Name = "lblDiscord";
            this.lblDiscord.Size = new System.Drawing.Size(158, 17);
            this.lblDiscord.TabIndex = 1;
            this.lblDiscord.Text = "Contacte-me no Discord:";
            // 
            // lblDiscordTag
            // 
            this.lblDiscordTag.AutoSize = true;
            this.lblDiscordTag.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDiscordTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblDiscordTag.Location = new System.Drawing.Point(173, 57);
            this.lblDiscordTag.Name = "lblDiscordTag";
            this.lblDiscordTag.Size = new System.Drawing.Size(53, 19);
            this.lblDiscordTag.TabIndex = 2;
            this.lblDiscordTag.Text = "mrgeh";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCredits.ForeColor = System.Drawing.Color.Gray;
            this.lblCredits.Location = new System.Drawing.Point(21, 92);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(218, 17);
            this.lblCredits.TabIndex = 3;
            this.lblCredits.Text = "Créditos: Desenvolvido por MrGeH";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(24, 128);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(262, 32);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "FECHAR";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(310, 180);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblDiscordTag);
            this.Controls.Add(this.lblDiscord);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajuda & Créditos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDiscord;
        private System.Windows.Forms.Label lblDiscordTag;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Button btnOk;
    }
}