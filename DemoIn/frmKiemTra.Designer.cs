﻿namespace DemoIn
{
    partial class frmKiemTra
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDocFile = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtDocScan = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDocFile
            // 
            this.txtDocFile.Location = new System.Drawing.Point(176, 38);
            this.txtDocFile.Name = "txtDocFile";
            this.txtDocFile.Size = new System.Drawing.Size(130, 20);
            this.txtDocFile.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtDocScan
            // 
            this.txtDocScan.Location = new System.Drawing.Point(176, 12);
            this.txtDocScan.Name = "txtDocScan";
            this.txtDocScan.Size = new System.Drawing.Size(130, 20);
            this.txtDocScan.TabIndex = 3;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(12, 15);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(68, 13);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "Giá trị đọc từ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giá trị đọc từ file";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(176, 64);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(130, 20);
            this.txtKetQua.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kết quả";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.ReadTimeout = 50;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "config";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(321, 15);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(13, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "_";
            // 
            // frmKiemTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 175);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtDocScan);
            this.Controls.Add(this.txtDocFile);
            this.Controls.Add(this.button2);
            this.Name = "frmKiemTra";
            this.Text = "Kiểm tra";
            this.Load += new System.EventHandler(this.frmKiemTra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtDocFile;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtDocScan;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblStatus;
    }
}