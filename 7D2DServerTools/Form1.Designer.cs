namespace _7D2DServerTools
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtConsoleOutput = new System.Windows.Forms.TextBox();
            this.txtConsoleInput = new System.Windows.Forms.TextBox();
            this.btnConsoleSend = new System.Windows.Forms.Button();
            this.pnlConnect = new System.Windows.Forms.Panel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tmrConsoleOutput = new System.Windows.Forms.Timer(this.components);
            this.lblServerIP = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.txtServerPassword = new System.Windows.Forms.TextBox();
            this.lblServerPassword = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(817, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnConsoleSend);
            this.tabPage1.Controls.Add(this.txtConsoleInput);
            this.tabPage1.Controls.Add(this.txtConsoleOutput);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(809, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Console";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(809, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Time Controls";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtConsoleOutput
            // 
            this.txtConsoleOutput.Location = new System.Drawing.Point(6, 6);
            this.txtConsoleOutput.Multiline = true;
            this.txtConsoleOutput.Name = "txtConsoleOutput";
            this.txtConsoleOutput.Size = new System.Drawing.Size(797, 387);
            this.txtConsoleOutput.TabIndex = 0;
            // 
            // txtConsoleInput
            // 
            this.txtConsoleInput.Location = new System.Drawing.Point(6, 399);
            this.txtConsoleInput.Name = "txtConsoleInput";
            this.txtConsoleInput.Size = new System.Drawing.Size(676, 20);
            this.txtConsoleInput.TabIndex = 1;
            // 
            // btnConsoleSend
            // 
            this.btnConsoleSend.Location = new System.Drawing.Point(688, 397);
            this.btnConsoleSend.Name = "btnConsoleSend";
            this.btnConsoleSend.Size = new System.Drawing.Size(115, 23);
            this.btnConsoleSend.TabIndex = 2;
            this.btnConsoleSend.Text = "Send";
            this.btnConsoleSend.UseVisualStyleBackColor = true;
            // 
            // pnlConnect
            // 
            this.pnlConnect.Controls.Add(this.txtServerPassword);
            this.pnlConnect.Controls.Add(this.lblServerPassword);
            this.pnlConnect.Controls.Add(this.txtServerPort);
            this.pnlConnect.Controls.Add(this.lblServerPort);
            this.pnlConnect.Controls.Add(this.txtServerIP);
            this.pnlConnect.Controls.Add(this.lblServerIP);
            this.pnlConnect.Controls.Add(this.btnConnect);
            this.pnlConnect.Location = new System.Drawing.Point(3, 12);
            this.pnlConnect.Name = "pnlConnect";
            this.pnlConnect.Size = new System.Drawing.Size(837, 456);
            this.pnlConnect.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(288, 233);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(258, 28);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tmrConsoleOutput
            // 
            this.tmrConsoleOutput.Interval = 10;
            this.tmrConsoleOutput.Tick += new System.EventHandler(this.tmrConsoleOutput_Tick);
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Location = new System.Drawing.Point(285, 155);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(61, 13);
            this.lblServerIP.TabIndex = 1;
            this.lblServerIP.Text = "IP Address:";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(352, 152);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(194, 20);
            this.txtServerIP.TabIndex = 2;
            // 
            // lblServerPort
            // 
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Location = new System.Drawing.Point(317, 183);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(29, 13);
            this.lblServerPort.TabIndex = 3;
            this.lblServerPort.Text = "Port:";
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(352, 180);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(194, 20);
            this.txtServerPort.TabIndex = 4;
            // 
            // txtServerPassword
            // 
            this.txtServerPassword.Location = new System.Drawing.Point(352, 207);
            this.txtServerPassword.Name = "txtServerPassword";
            this.txtServerPassword.Size = new System.Drawing.Size(194, 20);
            this.txtServerPassword.TabIndex = 6;
            // 
            // lblServerPassword
            // 
            this.lblServerPassword.AutoSize = true;
            this.lblServerPassword.Location = new System.Drawing.Point(290, 210);
            this.lblServerPassword.Name = "lblServerPassword";
            this.lblServerPassword.Size = new System.Drawing.Size(56, 13);
            this.lblServerPassword.TabIndex = 5;
            this.lblServerPassword.Text = "Password:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 480);
            this.Controls.Add(this.pnlConnect);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "7D2DServerTools";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnlConnect.ResumeLayout(false);
            this.pnlConnect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnConsoleSend;
        private System.Windows.Forms.TextBox txtConsoleInput;
        private System.Windows.Forms.TextBox txtConsoleOutput;
        private System.Windows.Forms.Panel pnlConnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Timer tmrConsoleOutput;
        private System.Windows.Forms.TextBox txtServerPassword;
        private System.Windows.Forms.Label lblServerPassword;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label lblServerIP;
    }
}

