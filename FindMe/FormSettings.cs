using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SwitchControl
{
    public partial class FormSettings : Form
    {
        //MySettings AppSettings = new MySettings();

        public FormSettings()
        {
            InitializeComponent();
            ReadSettings();
            
        }

        public int ReadSettings()
        {
            tbZabbixIP.Text = Properties.Settings.Default["ZabbixSrvIP"].ToString();
            tbDBLogin.Text = Properties.Settings.Default["ZabbixDBLogin"].ToString();
            tbDBPass.Text = Properties.Settings.Default["ZabbixDBPass"].ToString();
            tbHostGroup.Text = Properties.Settings.Default["ZabbixDBHostGroup"].ToString();
            tbOSeparator.Text = Properties.Settings.Default["MACOctetSeparator"].ToString();
            return (1);
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
