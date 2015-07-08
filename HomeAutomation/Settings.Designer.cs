namespace HomeAutomation
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serialPortSettings = new System.Windows.Forms.GroupBox();
            this.baudRate = new System.Windows.Forms.ComboBox();
            this.serialPort = new System.Windows.Forms.ComboBox();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.portNumberLabel = new System.Windows.Forms.Label();
            this.socketSettings = new System.Windows.Forms.GroupBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.portNumber = new System.Windows.Forms.TextBox();
            this.IP = new System.Windows.Forms.TextBox();
            this.IPLabel = new System.Windows.Forms.Label();
            this.quit = new System.Windows.Forms.Button();
            this.caution = new System.Windows.Forms.Label();
            this.loadDefault = new System.Windows.Forms.Button();
            this.serialPortSettings.SuspendLayout();
            this.socketSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPortSettings
            // 
            this.serialPortSettings.Controls.Add(this.baudRate);
            this.serialPortSettings.Controls.Add(this.serialPort);
            this.serialPortSettings.Controls.Add(this.baudRateLabel);
            this.serialPortSettings.Controls.Add(this.portNumberLabel);
            this.serialPortSettings.Location = new System.Drawing.Point(12, 12);
            this.serialPortSettings.Name = "serialPortSettings";
            this.serialPortSettings.Size = new System.Drawing.Size(190, 259);
            this.serialPortSettings.TabIndex = 0;
            this.serialPortSettings.TabStop = false;
            this.serialPortSettings.Text = "Serial Port Settings";
            // 
            // baudRate
            // 
            this.baudRate.FormattingEnabled = true;
            this.baudRate.Location = new System.Drawing.Point(84, 47);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(99, 21);
            this.baudRate.TabIndex = 3;
            // 
            // serialPort
            // 
            this.serialPort.FormattingEnabled = true;
            this.serialPort.Location = new System.Drawing.Point(84, 19);
            this.serialPort.Name = "serialPort";
            this.serialPort.Size = new System.Drawing.Size(100, 21);
            this.serialPort.TabIndex = 2;
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Location = new System.Drawing.Point(7, 50);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(58, 13);
            this.baudRateLabel.TabIndex = 2;
            this.baudRateLabel.Text = "Baud Rate";
            // 
            // portNumberLabel
            // 
            this.portNumberLabel.AutoSize = true;
            this.portNumberLabel.Location = new System.Drawing.Point(7, 22);
            this.portNumberLabel.Name = "portNumberLabel";
            this.portNumberLabel.Size = new System.Drawing.Size(66, 13);
            this.portNumberLabel.TabIndex = 0;
            this.portNumberLabel.Text = "Port Number";
            // 
            // socketSettings
            // 
            this.socketSettings.Controls.Add(this.portLabel);
            this.socketSettings.Controls.Add(this.portNumber);
            this.socketSettings.Controls.Add(this.IP);
            this.socketSettings.Controls.Add(this.IPLabel);
            this.socketSettings.Location = new System.Drawing.Point(208, 12);
            this.socketSettings.Name = "socketSettings";
            this.socketSettings.Size = new System.Drawing.Size(190, 259);
            this.socketSettings.TabIndex = 1;
            this.socketSettings.TabStop = false;
            this.socketSettings.Text = "Socket Settings";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(6, 50);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(66, 13);
            this.portLabel.TabIndex = 3;
            this.portLabel.Text = "Port Number";
            // 
            // portNumber
            // 
            this.portNumber.Location = new System.Drawing.Point(84, 47);
            this.portNumber.Name = "portNumber";
            this.portNumber.Size = new System.Drawing.Size(100, 20);
            this.portNumber.TabIndex = 2;
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(84, 19);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(100, 20);
            this.IP.TabIndex = 1;
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(6, 22);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(17, 13);
            this.IPLabel.TabIndex = 0;
            this.IPLabel.Text = "IP";
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(407, 248);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(183, 23);
            this.quit.TabIndex = 2;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // caution
            // 
            this.caution.AutoSize = true;
            this.caution.Location = new System.Drawing.Point(404, 31);
            this.caution.MinimumSize = new System.Drawing.Size(200, 26);
            this.caution.Name = "caution";
            this.caution.Size = new System.Drawing.Size(200, 26);
            this.caution.TabIndex = 3;
            // 
            // loadDefault
            // 
            this.loadDefault.Location = new System.Drawing.Point(407, 219);
            this.loadDefault.Name = "loadDefault";
            this.loadDefault.Size = new System.Drawing.Size(183, 23);
            this.loadDefault.TabIndex = 4;
            this.loadDefault.Text = "Load Default";
            this.loadDefault.UseVisualStyleBackColor = true;
            this.loadDefault.Click += new System.EventHandler(this.loadDefault_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 283);
            this.Controls.Add(this.loadDefault);
            this.Controls.Add(this.caution);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.socketSettings);
            this.Controls.Add(this.serialPortSettings);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.serialPortSettings.ResumeLayout(false);
            this.serialPortSettings.PerformLayout();
            this.socketSettings.ResumeLayout(false);
            this.socketSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox serialPortSettings;
        private System.Windows.Forms.ComboBox serialPort;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.Label portNumberLabel;
        private System.Windows.Forms.ComboBox baudRate;
        private System.Windows.Forms.GroupBox socketSettings;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox portNumber;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Label caution;
        private System.Windows.Forms.Button loadDefault;
    }
}