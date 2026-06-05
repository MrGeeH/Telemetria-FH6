namespace TelemetriaFH6
{
    partial class FormDevTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDevTest));
            this.lblDevTitle = new System.Windows.Forms.Label();
            this.grpVibration = new System.Windows.Forms.GroupBox();
            this.btnStopVib = new System.Windows.Forms.Button();
            this.btnTestVib = new System.Windows.Forms.Button();
            this.lblTrackRight = new System.Windows.Forms.Label();
            this.trackRightMotor = new System.Windows.Forms.TrackBar();
            this.lblTrackLeft = new System.Windows.Forms.Label();
            this.trackLeftMotor = new System.Windows.Forms.TrackBar();
            this.grpTelemetrySim = new System.Windows.Forms.GroupBox();
            this.lblRpmVal = new System.Windows.Forms.Label();
            this.btnToggleSim = new System.Windows.Forms.Button();
            this.trackRPM = new System.Windows.Forms.TrackBar();
            this.lblSimulateRPM = new System.Windows.Forms.Label();
            this.grpVibration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackRightMotor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLeftMotor)).BeginInit();
            this.grpTelemetrySim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackRPM)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDevTitle
            // 
            this.lblDevTitle.AutoSize = true;
            this.lblDevTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDevTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblDevTitle.Location = new System.Drawing.Point(12, 15);
            this.lblDevTitle.Name = "lblDevTitle";
            this.lblDevTitle.Size = new System.Drawing.Size(254, 21);
            this.lblDevTitle.TabIndex = 0;
            this.lblDevTitle.Text = "CENTRAL DE DIAGNÓSTICO DEV";
            // 
            // grpVibration
            // 
            this.grpVibration.Controls.Add(this.btnStopVib);
            this.grpVibration.Controls.Add(this.btnTestVib);
            this.grpVibration.Controls.Add(this.lblTrackRight);
            this.grpVibration.Controls.Add(this.trackRightMotor);
            this.grpVibration.Controls.Add(this.lblTrackLeft);
            this.grpVibration.Controls.Add(this.trackLeftMotor);
            this.grpVibration.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.grpVibration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpVibration.Location = new System.Drawing.Point(12, 50);
            this.grpVibration.Name = "grpVibration";
            this.grpVibration.Size = new System.Drawing.Size(390, 185);
            this.grpVibration.TabIndex = 1;
            this.grpVibration.TabStop = false;
            this.grpVibration.Text = "Diagnóstico Avançado de Hardware (XInput)";
            // 
            // btnStopVib
            // 
            this.btnStopVib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnStopVib.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopVib.FlatAppearance.BorderSize = 0;
            this.btnStopVib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopVib.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnStopVib.ForeColor = System.Drawing.Color.White;
            this.btnStopVib.Location = new System.Drawing.Point(202, 142);
            this.btnStopVib.Name = "btnStopVib";
            this.btnStopVib.Size = new System.Drawing.Size(170, 30);
            this.btnStopVib.TabIndex = 5;
            this.btnStopVib.Text = "Cortar Motores";
            this.btnStopVib.UseVisualStyleBackColor = false;
            this.btnStopVib.Click += new System.EventHandler(this.btnStopVib_Click);
            // 
            // btnTestVib
            // 
            this.btnTestVib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnTestVib.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestVib.FlatAppearance.BorderSize = 0;
            this.btnTestVib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestVib.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnTestVib.ForeColor = System.Drawing.Color.White;
            this.btnTestVib.Location = new System.Drawing.Point(16, 142);
            this.btnTestVib.Name = "btnTestVib";
            this.btnTestVib.Size = new System.Drawing.Size(170, 30);
            this.btnTestVib.TabIndex = 4;
            this.btnTestVib.Text = "TESTAR PULSAÇÃO TÁTIL";
            this.btnTestVib.UseVisualStyleBackColor = false;
            this.btnTestVib.Click += new System.EventHandler(this.btnTestVib_Click);
            // 
            // lblTrackRight
            // 
            this.lblTrackRight.AutoSize = true;
            this.lblTrackRight.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.lblTrackRight.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTrackRight.Location = new System.Drawing.Point(13, 85);
            this.lblTrackRight.Name = "lblTrackRight";
            this.lblTrackRight.Size = new System.Drawing.Size(185, 15);
            this.lblTrackRight.TabIndex = 3;
            this.lblTrackRight.Text = "Motor Direito (Agudo / RPM): 0%";
            // 
            // trackRightMotor
            // 
            this.trackRightMotor.Location = new System.Drawing.Point(10, 103);
            this.trackRightMotor.Maximum = 100;
            this.trackRightMotor.Name = "trackRightMotor";
            this.trackRightMotor.Size = new System.Drawing.Size(362, 45);
            this.trackRightMotor.TabIndex = 2;
            this.trackRightMotor.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackRightMotor.Scroll += new System.EventHandler(this.trackVibration_Scroll);
            // 
            // lblTrackLeft
            // 
            this.lblTrackLeft.AutoSize = true;
            this.lblTrackLeft.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.lblTrackLeft.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTrackLeft.Location = new System.Drawing.Point(13, 28);
            this.lblTrackLeft.Name = "lblTrackLeft";
            this.lblTrackLeft.Size = new System.Drawing.Size(207, 15);
            this.lblTrackLeft.TabIndex = 1;
            this.lblTrackLeft.Text = "Motor Esquerdo (Grave / Terreno): 0%";
            // 
            // trackLeftMotor
            // 
            this.trackLeftMotor.Location = new System.Drawing.Point(10, 46);
            this.trackLeftMotor.Maximum = 100;
            this.trackLeftMotor.Name = "trackLeftMotor";
            this.trackLeftMotor.Size = new System.Drawing.Size(362, 45);
            this.trackLeftMotor.TabIndex = 0;
            this.trackLeftMotor.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackLeftMotor.Scroll += new System.EventHandler(this.trackVibration_Scroll);
            // 
            // grpTelemetrySim
            // 
            this.grpTelemetrySim.Controls.Add(this.lblRpmVal);
            this.grpTelemetrySim.Controls.Add(this.btnToggleSim);
            this.grpTelemetrySim.Controls.Add(this.trackRPM);
            this.grpTelemetrySim.Controls.Add(this.lblSimulateRPM);
            this.grpTelemetrySim.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.grpTelemetrySim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpTelemetrySim.Location = new System.Drawing.Point(12, 245);
            this.grpTelemetrySim.Name = "grpTelemetrySim";
            this.grpTelemetrySim.Size = new System.Drawing.Size(390, 140);
            this.grpTelemetrySim.TabIndex = 2;
            this.grpTelemetrySim.TabStop = false;
            this.grpTelemetrySim.Text = "Simulador de Telemetria FH6 (Loopback Sem Jogo)";
            // 
            // lblRpmVal
            // 
            this.lblRpmVal.AutoSize = true;
            this.lblRpmVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblRpmVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblRpmVal.Location = new System.Drawing.Point(342, 30);
            this.lblRpmVal.Name = "lblRpmVal";
            this.lblRpmVal.Size = new System.Drawing.Size(26, 17);
            this.lblRpmVal.TabIndex = 3;
            this.lblRpmVal.Text = "0%";
            // 
            // btnToggleSim
            // 
            this.btnToggleSim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnToggleSim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleSim.FlatAppearance.BorderSize = 0;
            this.btnToggleSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleSim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnToggleSim.ForeColor = System.Drawing.Color.White;
            this.btnToggleSim.Location = new System.Drawing.Point(16, 93);
            this.btnToggleSim.Name = "btnToggleSim";
            this.btnToggleSim.Size = new System.Drawing.Size(356, 32);
            this.btnToggleSim.TabIndex = 2;
            this.btnToggleSim.Text = "INICIAR INJEÇÃO DE DADOS UDP";
            this.btnToggleSim.UseVisualStyleBackColor = false;
            this.btnToggleSim.Click += new System.EventHandler(this.btnToggleSim_Click);
            // 
            // trackRPM
            // 
            this.trackRPM.Location = new System.Drawing.Point(10, 52);
            this.trackRPM.Maximum = 100;
            this.trackRPM.Name = "trackRPM";
            this.trackRPM.Size = new System.Drawing.Size(362, 45);
            this.trackRPM.TabIndex = 1;
            this.trackRPM.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackRPM.Scroll += new System.EventHandler(this.trackRPM_Scroll);
            // 
            // lblSimulateRPM
            // 
            this.lblSimulateRPM.AutoSize = true;
            this.lblSimulateRPM.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.lblSimulateRPM.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSimulateRPM.Location = new System.Drawing.Point(13, 30);
            this.lblSimulateRPM.Name = "lblSimulateRPM";
            this.lblSimulateRPM.Size = new System.Drawing.Size(158, 15);
            this.lblSimulateRPM.TabIndex = 0;
            this.lblSimulateRPM.Text = "Forçar Porcentagem de Giro:";
            // 
            // FormDevTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(414, 401);
            this.Controls.Add(this.grpTelemetrySim);
            this.Controls.Add(this.grpVibration);
            this.Controls.Add(this.lblDevTitle);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDevTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Central de Testes Dev Avançada";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDevTest_FormClosing);
            this.grpVibration.ResumeLayout(false);
            this.grpVibration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackRightMotor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLeftMotor)).EndInit();
            this.grpTelemetrySim.ResumeLayout(false);
            this.grpTelemetrySim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackRPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDevTitle;
        private System.Windows.Forms.GroupBox grpVibration;
        private System.Windows.Forms.Label lblTrackLeft;
        private System.Windows.Forms.TrackBar trackLeftMotor;
        private System.Windows.Forms.Label lblTrackRight;
        private System.Windows.Forms.TrackBar trackRightMotor;
        private System.Windows.Forms.Button btnStopVib;
        private System.Windows.Forms.Button btnTestVib;
        private System.Windows.Forms.GroupBox grpTelemetrySim;
        private System.Windows.Forms.Label lblSimulateRPM;
        private System.Windows.Forms.TrackBar trackRPM;
        private System.Windows.Forms.Button btnToggleSim;
        private System.Windows.Forms.Label lblRpmVal;
    }
}