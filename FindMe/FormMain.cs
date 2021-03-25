using System;
//using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using MySql.Data.MySqlClient;
using System.Diagnostics;
//using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using SwitchControl.Models;
using SwitchControl.Controllers;
using System.Net.NetworkInformation;
using System.Net;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

//using System.Runtime.InteropServices;

//using SnmpSharpNet;

// ----------------------------------------------------- used
// ------------------------------------------- http://www.snmpsharpnet.com/ -------------------------------
// ------------------------------------------- 
namespace SwitchControl
{
    public partial class FormMain : Form
    {

        private int sortColumn = -1;
        private BindingList<HstGrp> hstGrp;
        private BindingList<Models.Switch> listHosts;
        private List<Host> hosts = new List<Host>();

        MySettings appSettings;
        public BindingSource bindingSource = null;
        DBController dbMain;
        NetController netHosts;
        private ListViewColumnSorter lvwColumnSorter;

        //-----------------------------------------------------------------------------------------------------------------------------

        public FormMain()
        {

            InitializeComponent();

            lvwColumnSorter = new ListViewColumnSorter();
            this.listView1.ListViewItemSorter = lvwColumnSorter;

            appSettings = new MySettings();
            appSettings.Read();
            dbMain = new DBController(appSettings);
            FillListDevices();
            ReadHosts();
            GetArpTable2ListAndFillHosts();
            if (dbMain.TestConnection())
                tsslDBStatus.Text = "connected to " + appSettings.DBIP;
            netHosts = new NetController();
            //ReadFromXML(); 
        }
        //-----------------------------------------------------------------------------------------------------------------------------
        int FillListDevices()
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = dbMain.ReadTable("SELECT groupid, name FROM hstgrp where internal <> 1");
            comboBox1.DataSource = bindingSource;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "groupid";
            comboBox1.SelectedValue = appSettings.GroupID;

            return (1);
        }
        //-----------------------------------------------------------------------------------------------------------------------------
        int ReadHosts()
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = dbMain.ReadTable(@"SELECT i.location, h.host, addr.ip, i.macaddress_a, i.host_router from hosts h

                LEFT join host_inventory i on h.hostid = i.hostid
                left join interface addr  on addr.hostid=h.hostid
                left join hosts_groups hg ON hg.hostid= i.hostid
                where h.status< 1 AND addr.port = 161  AND hg.groupid=" + appSettings.GroupID+" order by h.name");

            dgvDevicesList.DataSource = bindingSource.DataSource;
            return 1;
        }

        private void GetArpTable2ListAndFillHosts()
        {

            string str;
            Process process = new Process();
            process.StartInfo.FileName = "cmd";
            process.StartInfo.Arguments = "/C arp -a";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            //process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.Start();

            StreamReader reader = process.StandardOutput;
            //string patternIp = @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b";
            IPAddress address;
            ListViewItem listItem = new ListViewItem();
            while (!reader.EndOfStream)
            {
                str = reader.ReadLine();
                string[] words = str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if ((words.Length > 1) && (IPAddress.TryParse(words[0], out address)))
                {
                    hosts.Add(new Host(words[0], words[1]));

                    listItem = new ListViewItem(words[0]);
                    listItem.SubItems.Add(words[1]);
                    lvArp.Items.Add(listItem);
                }
            }
            tsslHosts.Text = lvArp.Items.Count.ToString();
        }



        //--------------------------------------------------------------------------------------------------------------
        private void btFind_Click(object sender, EventArgs e)
        {
            NetController testSwitch = new NetController("10.10.14.101");
            testSwitch.GetMacsOnPorts();
            //testSwitch.DecMAC2Hex();

            using (Process process = new Process())
            {
                process.StartInfo.FileName = @"d:\Temp\SnmpWalk.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.Arguments = "-r:" + tbIP.Text + " -v:2c -c:public -os:.1.3.6.1.2.1.17.7.1.2.2.1.2.1 -op:.1.3.6.1.2.1.17.7.1.2.2.1.2.2";
                process.Start();
           /*   1.3.6.1.2.1.1.1 - sysDescr
                1.3.6.1.2.1.1.2 - sysObjectID
                1.3.6.1.2.1.1.3 - sysUpTime
                1.3.6.1.2.1.1.4 - sysContact
                1.3.6.1.2.1.1.5 - sysName
                1.3.6.1.2.1.1.6 - sysLocation
                1.3.6.1.2.1.1.7 - sysServices    */
                // Synchronously read the standard output of the spawned process. 
                StreamReader reader = process.StandardOutput;
                string output = reader.ReadToEnd();
                //richTextBox1.Text = output;
                string[] words = output.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                ListViewItem l = new ListViewItem();
                String pattern = "(OID=.1.3.6.1.2.1.17.7.1.2.2.1.2.1.)|(Type=)|(Value=)";
                listView1.Items.Clear();
                string oct = "";
                string s;
                foreach (string str in words)
                {
                    l = new ListViewItem();
                    //l.Text = str;
                    foreach (string str2 in Regex.Split(str, ", "))
                    {
                        s = Regex.Replace(str2, pattern, String.Empty);
                        {
                            //if (s.Count('.') == 4)
                            {
                                string[] sw = s.Split('.');
                                string ff = "";
                                if (sw.Count() == 6)
                                {
                                    foreach (string ss in sw)
                                    {
                                        oct = Convert.ToString(Convert.ToInt32(ss), 16);
                                        if (oct.Length == 1)
                                            ff += "0";
                                        ff += (oct);
                                        ff += tbSeparator.Text;
                                    }
                                    s = ff.Substring(0, ff.Length - 1);
                                }
                            }
                            l.SubItems.Add(s);
                        }

                    }



                    //  Если есть фильтр порта
                    //if (l.SubItems.Count > 2 && l.SubItems[3].Text != cbPort.Text)
                    if (l.SubItems.Count > 2 && !cbPort.Text.Contains(l.SubItems[3].Text) /* && !cbPortFilter.Checked*/)
                    {
                        //                        tbIP.Text = dgvDevicesList.Rows[dgvDevicesList.CurrentRow.Index].Cells["Router"].Value.ToString();


                        // Еще условие - если стоит чекбокс показывать только порт - смотрим только его!!!
                        if (!cbOnlyPort.Checked && !cbOnlyIP.Checked)
                        {

                            //добавим в конец мак - только надо чтобы до этого считался лист ARP! 
                            string t = l.SubItems[1].Text;
                            l.SubItems.Add(GetIpFromMAC(l.SubItems[1].Text));
                            listView1.Items.Add(l);//добавим в лист}
                        }
                        else
                            if (l.SubItems[3].Text == tbPortOnly.Text)
                                {
                                    //добавим в конец мак - только надо чтобы до этого считался лист ARP! 
                                    string t = l.SubItems[1].Text;
                                    l.SubItems.Add(GetIpFromMAC(l.SubItems[1].Text));
                                    listView1.Items.Add(l);//добавим в лист}
                                }
                            else
                                {
                                    if (GetIpFromMAC(l.SubItems[1].Text) == tbIPAddr.Text)
                                    {
                                        //добавим в конец мак - только надо чтобы до этого считался лист ARP! 
                                        string t = l.SubItems[1].Text;
                                        l.SubItems.Add(GetIpFromMAC(l.SubItems[1].Text));
                                        listView1.Items.Add(l);//добавим в лист}
                                    }
                                }

                    }

                }    
                // Write the redirected output to this application's window.
                //Console.WriteLine(output);
                process.WaitForExit();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            tbIP.Text = dgvDevicesList.Rows[dgvDevicesList.CurrentRow.Index].Cells["IP"].Value.ToString();
            cbPort.Text = dgvDevicesList.Rows[dgvDevicesList.CurrentRow.Index].Cells["Router"].Value.ToString();
            //dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ip"]
            //dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells.

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            FormSettings newFormSet = new FormSettings();
            newFormSet.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //     private BindingList<HstGrp> hstGrp;
            hstGrp = new BindingList<HstGrp>();

        }

        private void btPing_Click(object sender, EventArgs e)
        {
            PingHosts();
        }

        private void PingHosts()
        {

            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();
            options.DontFragment = true;
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";  //32 байта
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 2000;

            for (int i = 0; i < dgvDevicesList.RowCount; i++)
                dgvDevicesList.Rows[i].Cells["Online"].Value = "";
            for (int i = 0; i< dgvDevicesList.RowCount; i++ )
                {
                   string sss = dgvDevicesList.Rows[i].Cells["ip"].Value.ToString();
                 PingReply reply = pingSender.Send(sss, timeout, buffer, options);
                             // Можно добавить reply.Options.Ttl

                             if (reply.Status == IPStatus.Success)
                                 if (reply.RoundtripTime==0)
                        dgvDevicesList.Rows[i].Cells["Online"].Value = "< 0";
                                 else
                        dgvDevicesList.Rows[i].Cells["Online"].Value = reply.RoundtripTime.ToString();
                             else
                    dgvDevicesList.Rows[i].Cells["Online"].Value = "-";
                dgvDevicesList.Refresh();
                         }
        }
        //---------------------------------------------------------------
        int ReadFromXML()
        {
            int CurCell = 0;
            int RegCount = 0;

            //IP-MAC-IN
            XmlDocument document = new XmlDocument();
            document.Load("Devices.xml");
            XmlNodeReader reader = new XmlNodeReader(document);
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Text:
                        dgvDevicesList.RowCount++;
                        dgvDevicesList.Rows[RegCount].Cells[CurCell++].Value = reader.Value;
                        break;
                    case XmlNodeType.EndElement:
                        if (reader.Name == "Device")
                        {
                            RegCount++; CurCell = 0;
                        }
                        break;
                }
            }
            dgvDevicesList.RowCount = RegCount;
            return 1;
        }

        private void bScan_Click(object sender, EventArgs e)
        {
            netHosts.ScanSubnets();
            MessageBox.Show("Ping прошел", "Выполнено", MessageBoxButtons.OK);

        }

        private void bGetArp_Click(object sender, EventArgs e)
        {
            GetArpTable2ListAndFillHosts();
        }

        private void dgvDevicesList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btFind_Click(this, e);
        }

        private string GetIpFromMAC(string mac)
        {
            string s;

            try
            {
                s = hosts.Find(x => x.HostMAC.Contains(mac)).HostIp;
            }
            catch {
                s = " ";
            }

            if (s != null)
                return (s);
            else
                return (" ");
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string s;
            s = listView1.FocusedItem.SubItems[1].Text;
            Clipboard.SetText(s);


        }

        private void bClearARP_Click(object sender, EventArgs e)
        {
            // interface ip delete arpcache
        }

        private void dgvDevicesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }
            this.listView1.Sort();
        }
    }
}

