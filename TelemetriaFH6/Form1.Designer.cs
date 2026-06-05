namespace TelemetriaFH6
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxControllers = new System.Windows.Forms.ComboBox();
            this.chkShiftLight = new System.Windows.Forms.CheckBox();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.progressBarRPM = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.chkReduceGameVibration = new System.Windows.Forms.CheckBox();
            this.txtIntensity = new System.Windows.Forms.TextBox();
            this.lblIntensityTitle = new System.Windows.Forms.Label();
            this.cmbVibrationStyle = new System.Windows.Forms.ComboBox();
            this.lblStyleTitle = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(308, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray;
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            this.opçõesToolStripMenuItem.Click += new System.EventHandler(this.opçõesToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // listBoxControllers
            // 
            this.listBoxControllers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.listBoxControllers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listBoxControllers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listBoxControllers.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.listBoxControllers.ForeColor = System.Drawing.Color.White;
            this.listBoxControllers.FormattingEnabled = true;
            this.listBoxControllers.Location = new System.Drawing.Point(12, 38);
            this.listBoxControllers.Name = "listBoxControllers";
            this.listBoxControllers.Size = new System.Drawing.Size(260, 23);
            this.listBoxControllers.TabIndex = 1;
            // 
            // chkShiftLight
            // 
            this.chkShiftLight.AutoSize = true;
            this.chkShiftLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkShiftLight.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.chkShiftLight.ForeColor = System.Drawing.Color.White;
            this.chkShiftLight.Location = new System.Drawing.Point(12, 77);
            this.chkShiftLight.Name = "chkShiftLight";
            this.chkShiftLight.Size = new System.Drawing.Size(134, 19);
            this.chkShiftLight.TabIndex = 2;
            this.chkShiftLight.Text = "Ativar ShiftLight Tátil";
            this.chkShiftLight.UseVisualStyleBackColor = true;
            // 
            // txtPercentage
            // 
            this.txtPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPercentage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPercentage.Location = new System.Drawing.Point(254, 75);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(42, 23);
            this.txtPercentage.TabIndex = 3;
            this.txtPercentage.Text = "80";
            this.txtPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(12, 215);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(121, 15);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status: Aguardando...";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(75)))), ((int)(((byte)(90)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(12, 238);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(260, 35);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Iniciar Escuta";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // progressBarRPM
            // 
            this.progressBarRPM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.progressBarRPM.Location = new System.Drawing.Point(12, 182);
            this.progressBarRPM.Name = "progressBarRPM";
            this.progressBarRPM.Size = new System.Drawing.Size(260, 18);
            this.progressBarRPM.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarRPM.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(149, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "PULSO RPM AVISO";
            // 
            // chkReduceGameVibration
            // 
            this.chkReduceGameVibration.AutoSize = true;
            this.chkReduceGameVibration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkReduceGameVibration.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.chkReduceGameVibration.ForeColor = System.Drawing.Color.White;
            this.chkReduceGameVibration.Location = new System.Drawing.Point(12, 105);
            this.chkReduceGameVibration.Name = "chkReduceGameVibration";
            this.chkReduceGameVibration.Size = new System.Drawing.Size(227, 19);
            this.chkReduceGameVibration.TabIndex = 8;
            this.chkReduceGameVibration.Text = "Filtro Terreno (Vibração jogo reduzida)";
            this.chkReduceGameVibration.UseVisualStyleBackColor = true;
            // 
            // txtIntensity
            // 
            this.txtIntensity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtIntensity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIntensity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtIntensity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtIntensity.Location = new System.Drawing.Point(12, 147);
            this.txtIntensity.Name = "txtIntensity";
            this.txtIntensity.Size = new System.Drawing.Size(50, 23);
            this.txtIntensity.TabIndex = 9;
            this.txtIntensity.Text = "100";
            this.txtIntensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIntensityTitle
            // 
            this.lblIntensityTitle.AutoSize = true;
            this.lblIntensityTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblIntensityTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblIntensityTitle.Location = new System.Drawing.Point(12, 131);
            this.lblIntensityTitle.Name = "lblIntensityTitle";
            this.lblIntensityTitle.Size = new System.Drawing.Size(47, 13);
            this.lblIntensityTitle.TabIndex = 10;
            this.lblIntensityTitle.Text = "Força %";
            // 
            // cmbVibrationStyle
            // 
            this.cmbVibrationStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cmbVibrationStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVibrationStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVibrationStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.cmbVibrationStyle.ForeColor = System.Drawing.Color.White;
            this.cmbVibrationStyle.FormattingEnabled = true;
            this.cmbVibrationStyle.Location = new System.Drawing.Point(80, 147);
            this.cmbVibrationStyle.Name = "cmbVibrationStyle";
            this.cmbVibrationStyle.Size = new System.Drawing.Size(192, 23);
            this.cmbVibrationStyle.TabIndex = 11;
            // 
            // lblStyleTitle
            // 
            this.lblStyleTitle.AutoSize = true;
            this.lblStyleTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblStyleTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblStyleTitle.Location = new System.Drawing.Point(80, 131);
            this.lblStyleTitle.Name = "lblStyleTitle";
            this.lblStyleTitle.Size = new System.Drawing.Size(68, 13);
            this.lblStyleTitle.TabIndex = 12;
            this.lblStyleTitle.Text = "Estilo Alerta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(308, 285);
            this.Controls.Add(this.lblStyleTitle);
            this.Controls.Add(this.cmbVibrationStyle);
            this.Controls.Add(this.lblIntensityTitle);
            this.Controls.Add(this.txtIntensity);
            this.Controls.Add(this.chkReduceGameVibration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarRPM);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.chkShiftLight);
            this.Controls.Add(this.listBoxControllers);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telemetria FH6 - MrGeH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ComboBox listBoxControllers;
        private System.Windows.Forms.CheckBox chkShiftLight;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar progressBarRPM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkReduceGameVibration;
        private System.Windows.Forms.TextBox txtIntensity;
        private System.Windows.Forms.Label lblIntensityTitle;
        private System.Windows.Forms.ComboBox cmbVibrationStyle;
        private System.Windows.Forms.Label lblStyleTitle;
    }
}