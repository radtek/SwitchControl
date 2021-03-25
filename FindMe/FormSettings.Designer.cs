namespace SwitchControl
{
    partial class FormSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bTestConnection = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDBPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDBLogin = new System.Windows.Forms.TextBox();
            this.tbZabbixIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHostGroup = new System.Windows.Forms.TextBox();
            this.tbOSeparator = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bTestConnection);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbDBPass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbDBLogin);
            this.groupBox1.Controls.Add(this.tbZabbixIP);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zabbix DB";
            // 
            // bTestConnection
            // 
            this.bTestConnection.Location = new System.Drawing.Point(15, 104);
            this.bTestConnection.Name = "bTestConnection";
            this.bTestConnection.Size = new System.Drawing.Size(66, 26);
            this.bTestConnection.TabIndex = 6;
            this.bTestConnection.Text = "Test";
            this.bTestConnection.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "pass";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "login";
            // 
            // tbDBPass
            // 
            this.tbDBPass.Location = new System.Drawing.Point(47, 78);
            this.tbDBPass.Name = "tbDBPass";
            this.tbDBPass.PasswordChar = '*';
            this.tbDBPass.Size = new System.Drawing.Size(100, 20);
            this.tbDBPass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // tbDBLogin
            // 
            this.tbDBLogin.Location = new System.Drawing.Point(47, 48);
            this.tbDBLogin.Name = "tbDBLogin";
            this.tbDBLogin.Size = new System.Drawing.Size(100, 20);
            this.tbDBLogin.TabIndex = 1;
            // 
            // tbZabbixIP
            // 
            this.tbZabbixIP.Location = new System.Drawing.Point(47, 17);
            this.tbZabbixIP.Name = "tbZabbixIP";
            this.tbZabbixIP.Size = new System.Drawing.Size(100, 20);
            this.tbZabbixIP.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Host group";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "MAC octet separator";
            // 
            // tbHostGroup
            // 
            this.tbHostGroup.Location = new System.Drawing.Point(244, 23);
            this.tbHostGroup.Name = "tbHostGroup";
            this.tbHostGroup.Size = new System.Drawing.Size(67, 20);
            this.tbHostGroup.TabIndex = 7;
            // 
            // tbOSeparator
            // 
            this.tbOSeparator.Location = new System.Drawing.Point(289, 49);
            this.tbOSeparator.Name = "tbOSeparator";
            this.tbOSeparator.Size = new System.Drawing.Size(22, 20);
            this.tbOSeparator.TabIndex = 6;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 159);
            this.Controls.Add(this.tbHostGroup);
            this.Controls.Add(this.tbOSeparator);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDBPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDBLogin;
        private System.Windows.Forms.TextBox tbZabbixIP;
        private System.Windows.Forms.Button bTestConnection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHostGroup;
        private System.Windows.Forms.TextBox tbOSeparator;
    }
}