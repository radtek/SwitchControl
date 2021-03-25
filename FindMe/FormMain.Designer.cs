namespace SwitchControl
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader columnHeader2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btFind = new System.Windows.Forms.Button();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDBStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslHosts = new System.Windows.Forms.ToolStripStatusLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.dgvDevicesList = new System.Windows.Forms.DataGridView();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.host = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.online = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Router = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSettings = new System.Windows.Forms.Button();
            this.tbSeparator = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btPing = new System.Windows.Forms.Button();
            this.bScan = new System.Windows.Forms.Button();
            this.bGetArp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bClearARP = new System.Windows.Forms.Button();
            this.tbIPAddr = new System.Windows.Forms.TextBox();
            this.cbOnlyIP = new System.Windows.Forms.CheckBox();
            this.tbPortOnly = new System.Windows.Forms.TextBox();
            this.cbOnlyPort = new System.Windows.Forms.CheckBox();
            this.lvArp = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbPortFilter = new System.Windows.Forms.CheckBox();
            this.switchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevicesList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeader2
            // 
            columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader2.Width = 1;
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(410, 18);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(59, 56);
            this.btFind.TabIndex = 0;
            this.btFind.Text = "get OIDs";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(324, 25);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(76, 20);
            this.tbIP.TabIndex = 3;
            this.tbIP.Text = "10.10.14.127";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selected switch:";
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslDBStatus,
            this.toolStripStatusLabel3,
            this.tsslHosts});
            this.statusStripMain.Location = new System.Drawing.Point(0, 692);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(810, 24);
            this.statusStripMain.TabIndex = 5;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(64, 19);
            this.toolStripStatusLabel1.Text = "DB Zabbix:";
            // 
            // tsslDBStatus
            // 
            this.tsslDBStatus.Name = "tsslDBStatus";
            this.tsslDBStatus.Size = new System.Drawing.Size(78, 19);
            this.tsslDBStatus.Text = "disconnected";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(82, 19);
            this.toolStripStatusLabel3.Text = "Known hosts:";
            // 
            // tsslHosts
            // 
            this.tsslHosts.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslHosts.Name = "tsslHosts";
            this.tsslHosts.Size = new System.Drawing.Size(16, 19);
            this.tsslHosts.Text = "-";
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.OID,
            columnHeader2,
            this.Port,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(475, 107);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(300, 490);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 20;
            // 
            // OID
            // 
            this.OID.Text = "MAC";
            this.OID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OID.Width = 110;
            // 
            // Port
            // 
            this.Port.Text = "Port";
            this.Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Port.Width = 45;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "IP";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Exclude ports:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "MAC octet separator";
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28"});
            this.cbPort.Location = new System.Drawing.Point(565, 21);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(56, 21);
            this.cbPort.TabIndex = 12;
            this.cbPort.Text = "25";
            // 
            // dgvDevicesList
            // 
            this.dgvDevicesList.AllowUserToAddRows = false;
            this.dgvDevicesList.AllowUserToDeleteRows = false;
            this.dgvDevicesList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevicesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDevicesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevicesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Location,
            this.host,
            this.ip,
            this.mac,
            this.online,
            this.Router});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDevicesList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDevicesList.Location = new System.Drawing.Point(12, 82);
            this.dgvDevicesList.MultiSelect = false;
            this.dgvDevicesList.Name = "dgvDevicesList";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevicesList.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDevicesList.RowHeadersWidth = 15;
            this.dgvDevicesList.RowTemplate.Height = 16;
            this.dgvDevicesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevicesList.Size = new System.Drawing.Size(457, 583);
            this.dgvDevicesList.TabIndex = 13;
            this.dgvDevicesList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevicesList_CellClick);
            this.dgvDevicesList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevicesList_CellDoubleClick);
            this.dgvDevicesList.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Location.DefaultCellStyle = dataGridViewCellStyle2;
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            this.Location.Width = 70;
            // 
            // host
            // 
            this.host.DataPropertyName = "host";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.host.DefaultCellStyle = dataGridViewCellStyle3;
            this.host.HeaderText = "Name";
            this.host.Name = "host";
            this.host.ReadOnly = true;
            this.host.Width = 70;
            // 
            // ip
            // 
            this.ip.DataPropertyName = "ip";
            this.ip.HeaderText = "IP";
            this.ip.Name = "ip";
            this.ip.ReadOnly = true;
            this.ip.Width = 75;
            // 
            // mac
            // 
            this.mac.DataPropertyName = "macaddress_a";
            this.mac.HeaderText = "MAC";
            this.mac.Name = "mac";
            this.mac.ReadOnly = true;
            this.mac.Width = 110;
            // 
            // online
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.online.DefaultCellStyle = dataGridViewCellStyle4;
            this.online.HeaderText = "Online";
            this.online.Name = "online";
            this.online.ReadOnly = true;
            this.online.Width = 45;
            // 
            // Router
            // 
            this.Router.DataPropertyName = "host_router";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Router.DefaultCellStyle = dataGridViewCellStyle5;
            this.Router.HeaderText = "Exclude";
            this.Router.Name = "Router";
            this.Router.Width = 70;
            // 
            // btSettings
            // 
            this.btSettings.Location = new System.Drawing.Point(22, 19);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(52, 23);
            this.btSettings.TabIndex = 14;
            this.btSettings.Text = "SETT";
            this.btSettings.UseVisualStyleBackColor = true;
            this.btSettings.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSeparator
            // 
            this.tbSeparator.Location = new System.Drawing.Point(274, 52);
            this.tbSeparator.Name = "tbSeparator";
            this.tbSeparator.Size = new System.Drawing.Size(18, 20);
            this.tbSeparator.TabIndex = 10;
            this.tbSeparator.Text = "-";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(79, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Show group:";
            // 
            // btPing
            // 
            this.btPing.Location = new System.Drawing.Point(298, 50);
            this.btPing.Name = "btPing";
            this.btPing.Size = new System.Drawing.Size(47, 23);
            this.btPing.TabIndex = 18;
            this.btPing.Text = "Ping";
            this.btPing.UseVisualStyleBackColor = true;
            this.btPing.Click += new System.EventHandler(this.btPing_Click);
            // 
            // bScan
            // 
            this.bScan.Location = new System.Drawing.Point(80, 19);
            this.bScan.Name = "bScan";
            this.bScan.Size = new System.Drawing.Size(82, 23);
            this.bScan.TabIndex = 19;
            this.bScan.Text = "Scan subnets";
            this.bScan.UseVisualStyleBackColor = true;
            this.bScan.Click += new System.EventHandler(this.bScan_Click);
            // 
            // bGetArp
            // 
            this.bGetArp.Location = new System.Drawing.Point(168, 18);
            this.bGetArp.Name = "bGetArp";
            this.bGetArp.Size = new System.Drawing.Size(65, 24);
            this.bGetArp.TabIndex = 20;
            this.bGetArp.Text = "Get ARP";
            this.bGetArp.UseVisualStyleBackColor = true;
            this.bGetArp.Click += new System.EventHandler(this.bGetArp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.bClearARP);
            this.groupBox1.Controls.Add(this.tbIPAddr);
            this.groupBox1.Controls.Add(this.cbOnlyIP);
            this.groupBox1.Controls.Add(this.tbPortOnly);
            this.groupBox1.Controls.Add(this.cbOnlyPort);
            this.groupBox1.Controls.Add(this.lvArp);
            this.groupBox1.Controls.Add(this.cbPortFilter);
            this.groupBox1.Controls.Add(this.bGetArp);
            this.groupBox1.Controls.Add(this.dgvDevicesList);
            this.groupBox1.Controls.Add(this.tbIP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bScan);
            this.groupBox1.Controls.Add(this.btPing);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btSettings);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbPort);
            this.groupBox1.Controls.Add(this.btFind);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbSeparator);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 679);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 629);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "ARP:";
            // 
            // bClearARP
            // 
            this.bClearARP.Location = new System.Drawing.Point(239, 18);
            this.bClearARP.Name = "bClearARP";
            this.bClearARP.Size = new System.Drawing.Size(65, 24);
            this.bClearARP.TabIndex = 27;
            this.bClearARP.Text = "Clear ARP";
            this.bClearARP.UseVisualStyleBackColor = true;
            this.bClearARP.Click += new System.EventHandler(this.bClearARP_Click);
            // 
            // tbIPAddr
            // 
            this.tbIPAddr.Location = new System.Drawing.Point(530, 56);
            this.tbIPAddr.Name = "tbIPAddr";
            this.tbIPAddr.Size = new System.Drawing.Size(111, 20);
            this.tbIPAddr.TabIndex = 26;
            this.tbIPAddr.Text = "10.10.10.15";
            // 
            // cbOnlyIP
            // 
            this.cbOnlyIP.AutoSize = true;
            this.cbOnlyIP.Location = new System.Drawing.Point(647, 61);
            this.cbOnlyIP.Name = "cbOnlyIP";
            this.cbOnlyIP.Size = new System.Drawing.Size(60, 17);
            this.cbOnlyIP.TabIndex = 25;
            this.cbOnlyIP.Text = "Only IP";
            this.cbOnlyIP.UseVisualStyleBackColor = true;
            // 
            // tbPortOnly
            // 
            this.tbPortOnly.Location = new System.Drawing.Point(606, 81);
            this.tbPortOnly.Name = "tbPortOnly";
            this.tbPortOnly.Size = new System.Drawing.Size(34, 20);
            this.tbPortOnly.TabIndex = 24;
            // 
            // cbOnlyPort
            // 
            this.cbOnlyPort.AutoSize = true;
            this.cbOnlyPort.Location = new System.Drawing.Point(647, 84);
            this.cbOnlyPort.Name = "cbOnlyPort";
            this.cbOnlyPort.Size = new System.Drawing.Size(68, 17);
            this.cbOnlyPort.TabIndex = 23;
            this.cbOnlyPort.Text = "Only port";
            this.cbOnlyPort.UseVisualStyleBackColor = true;
            // 
            // lvArp
            // 
            this.lvArp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4});
            this.lvArp.FullRowSelect = true;
            this.lvArp.GridLines = true;
            this.lvArp.HideSelection = false;
            this.lvArp.Location = new System.Drawing.Point(545, 603);
            this.lvArp.Name = "lvArp";
            this.lvArp.Size = new System.Drawing.Size(228, 67);
            this.lvArp.TabIndex = 22;
            this.lvArp.UseCompatibleStateImageBehavior = false;
            this.lvArp.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IP";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "MAC";
            this.columnHeader4.Width = 125;
            // 
            // cbPortFilter
            // 
            this.cbPortFilter.AutoSize = true;
            this.cbPortFilter.Checked = true;
            this.cbPortFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPortFilter.Location = new System.Drawing.Point(639, 23);
            this.cbPortFilter.Name = "cbPortFilter";
            this.cbPortFilter.Size = new System.Drawing.Size(66, 17);
            this.cbPortFilter.TabIndex = 20;
            this.cbPortFilter.Text = "port filter";
            this.cbPortFilter.UseVisualStyleBackColor = true;
            // 
            // switchBindingSource
            // 
            this.switchBindingSource.DataSource = typeof(SwitchControl.Models.Switch);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 716);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "HostFinder  (c) Kandakov Dmitry 2020";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevicesList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader OID;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader Port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.DataGridView dgvDevicesList;
        private System.Windows.Forms.Button btSettings;
        private System.Windows.Forms.TextBox tbSeparator;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslDBStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPing;
        private System.Windows.Forms.Button bScan;
        private System.Windows.Forms.Button bGetArp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvArp;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.CheckBox cbPortFilter;
        private System.Windows.Forms.BindingSource switchBindingSource;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.TextBox tbPortOnly;
        private System.Windows.Forms.CheckBox cbOnlyPort;
        private System.Windows.Forms.TextBox tbIPAddr;
        private System.Windows.Forms.CheckBox cbOnlyIP;
        private System.Windows.Forms.Button bClearARP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn host;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn mac;
        private System.Windows.Forms.DataGridViewTextBoxColumn online;
        private System.Windows.Forms.DataGridViewTextBoxColumn Router;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripStatusLabel tsslHosts;
    }
}

