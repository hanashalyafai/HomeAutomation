namespace HomeAutomation
{
    partial  class  mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.statusBox = new System.Windows.Forms.GroupBox();
            this.status = new System.Windows.Forms.Label();
            this.notSet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.quit = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flushLog = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.startWhole = new System.Windows.Forms.Button();
            this.stopLogging = new System.Windows.Forms.Button();
            this.startSerialPort = new System.Windows.Forms.Button();
            this.stopSerialPort = new System.Windows.Forms.Button();
            this.startLogging = new System.Windows.Forms.Button();
            this.stopWhole = new System.Windows.Forms.Button();
            this.startSocketPort = new System.Windows.Forms.Button();
            this.stopSocketPort = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.statusBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.statusBox);
            this.mainPanel.Controls.Add(this.notSet);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.quit);
            this.mainPanel.Controls.Add(this.settings);
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(578, 259);
            this.mainPanel.TabIndex = 8;
            // 
            // statusBox
            // 
            this.statusBox.Controls.Add(this.status);
            this.statusBox.Location = new System.Drawing.Point(3, 168);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(315, 88);
            this.statusBox.TabIndex = 21;
            this.statusBox.TabStop = false;
            this.statusBox.Text = "status";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(7, 16);
            this.status.MaximumSize = new System.Drawing.Size(311, 84);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 13);
            this.status.TabIndex = 0;
            // 
            // notSet
            // 
            this.notSet.Location = new System.Drawing.Point(324, 233);
            this.notSet.Name = "notSet";
            this.notSet.Size = new System.Drawing.Size(75, 23);
            this.notSet.TabIndex = 20;
            this.notSet.Text = "Technical";
            this.notSet.UseVisualStyleBackColor = true;
            this.notSet.Click += new System.EventHandler(this.notSet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(324, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(500, 233);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 23);
            this.quit.TabIndex = 18;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(405, 233);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(89, 23);
            this.settings.TabIndex = 17;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flushLog);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lable1);
            this.groupBox1.Controls.Add(this.startWhole);
            this.groupBox1.Controls.Add(this.stopLogging);
            this.groupBox1.Controls.Add(this.startSerialPort);
            this.groupBox1.Controls.Add(this.stopSerialPort);
            this.groupBox1.Controls.Add(this.startLogging);
            this.groupBox1.Controls.Add(this.stopWhole);
            this.groupBox1.Controls.Add(this.startSocketPort);
            this.groupBox1.Controls.Add(this.stopSocketPort);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 159);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // flushLog
            // 
            this.flushLog.Location = new System.Drawing.Point(231, 110);
            this.flushLog.Name = "flushLog";
            this.flushLog.Size = new System.Drawing.Size(75, 23);
            this.flushLog.TabIndex = 20;
            this.flushLog.Text = "flush log";
            this.flushLog.UseVisualStyleBackColor = true;
            this.flushLog.Click += new System.EventHandler(this.flushLog_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "socket port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "serial port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "logging info";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(7, 28);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(56, 13);
            this.lable1.TabIndex = 16;
            this.lable1.Text = "whole app";
            // 
            // startWhole
            // 
            this.startWhole.Location = new System.Drawing.Point(69, 23);
            this.startWhole.Name = "startWhole";
            this.startWhole.Size = new System.Drawing.Size(75, 23);
            this.startWhole.TabIndex = 8;
            this.startWhole.Text = "start";
            this.startWhole.UseVisualStyleBackColor = true;
            this.startWhole.Click += new System.EventHandler(this.startWhole_Click);
            // 
            // stopLogging
            // 
            this.stopLogging.Location = new System.Drawing.Point(150, 110);
            this.stopLogging.Name = "stopLogging";
            this.stopLogging.Size = new System.Drawing.Size(75, 23);
            this.stopLogging.TabIndex = 15;
            this.stopLogging.Text = "stop";
            this.stopLogging.UseVisualStyleBackColor = true;
            this.stopLogging.Click += new System.EventHandler(this.stopLogging_Click);
            // 
            // startSerialPort
            // 
            this.startSerialPort.Location = new System.Drawing.Point(69, 81);
            this.startSerialPort.Name = "startSerialPort";
            this.startSerialPort.Size = new System.Drawing.Size(75, 23);
            this.startSerialPort.TabIndex = 10;
            this.startSerialPort.Text = "start";
            this.startSerialPort.UseVisualStyleBackColor = true;
            this.startSerialPort.Click += new System.EventHandler(this.startSerialPort_Click);
            // 
            // stopSerialPort
            // 
            this.stopSerialPort.Location = new System.Drawing.Point(150, 81);
            this.stopSerialPort.Name = "stopSerialPort";
            this.stopSerialPort.Size = new System.Drawing.Size(75, 23);
            this.stopSerialPort.TabIndex = 14;
            this.stopSerialPort.Text = "stop";
            this.stopSerialPort.UseVisualStyleBackColor = true;
            this.stopSerialPort.Click += new System.EventHandler(this.stopSerialPort_Click);
            // 
            // startLogging
            // 
            this.startLogging.Location = new System.Drawing.Point(69, 110);
            this.startLogging.Name = "startLogging";
            this.startLogging.Size = new System.Drawing.Size(75, 23);
            this.startLogging.TabIndex = 11;
            this.startLogging.Text = "start";
            this.startLogging.UseVisualStyleBackColor = true;
            this.startLogging.Click += new System.EventHandler(this.startLogging_Click);
            // 
            // stopWhole
            // 
            this.stopWhole.Location = new System.Drawing.Point(150, 23);
            this.stopWhole.Name = "stopWhole";
            this.stopWhole.Size = new System.Drawing.Size(75, 23);
            this.stopWhole.TabIndex = 12;
            this.stopWhole.Text = "stop";
            this.stopWhole.UseVisualStyleBackColor = true;
            this.stopWhole.Click += new System.EventHandler(this.stopWhole_Click);
            // 
            // startSocketPort
            // 
            this.startSocketPort.Location = new System.Drawing.Point(69, 52);
            this.startSocketPort.Name = "startSocketPort";
            this.startSocketPort.Size = new System.Drawing.Size(75, 23);
            this.startSocketPort.TabIndex = 9;
            this.startSocketPort.Text = "start";
            this.startSocketPort.UseVisualStyleBackColor = true;
            this.startSocketPort.Click += new System.EventHandler(this.startSocketPort_Click);
            // 
            // stopSocketPort
            // 
            this.stopSocketPort.Location = new System.Drawing.Point(150, 52);
            this.stopSocketPort.Name = "stopSocketPort";
            this.stopSocketPort.Size = new System.Drawing.Size(75, 23);
            this.stopSocketPort.TabIndex = 13;
            this.stopSocketPort.Text = "stop";
            this.stopSocketPort.UseVisualStyleBackColor = true;
            this.stopSocketPort.Click += new System.EventHandler(this.stopSocketPort_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 283);
            this.Controls.Add(this.mainPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Automation";
            this.mainPanel.ResumeLayout(false);
            this.statusBox.ResumeLayout(false);
            this.statusBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stopLogging;
        private System.Windows.Forms.Button stopSerialPort;
        private System.Windows.Forms.Button stopSocketPort;
        private System.Windows.Forms.Button stopWhole;
        private System.Windows.Forms.Button startLogging;
        private System.Windows.Forms.Button startSerialPort;
        private System.Windows.Forms.Button startSocketPort;
        private System.Windows.Forms.Button startWhole;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Button flushLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.GroupBox statusBox;
        private System.Windows.Forms.Button notSet;
        private System.Windows.Forms.Label status;

    }
}

