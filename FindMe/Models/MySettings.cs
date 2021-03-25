using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchControl.Models
{
    class MySettings
    {
        public string DBIP;
        public string DBLogin;
        public string DBPassword;
        public string ConnString;
        public int GroupID;
        public char MACSeparator;
        public string Comunity;

        public MySettings()
        {
            DBIP = "10.10.10.7";
            DBLogin = "admin";
            DBPassword = "P@$$word";
            GroupID = 17;
            MACSeparator = '-';
        }
        public bool Read()
        {
            bool stateFindFileSetting = true;
            try
            {
                DBIP = Properties.Settings.Default["ZabbixSrvIP"].ToString();
                DBLogin = Properties.Settings.Default["ZabbixDBLogin"].ToString();
                DBPassword = Properties.Settings.Default["ZabbixDBPass"].ToString();
                ConnString = "server=" + DBIP + ";database=zabbix;uid=" +
                    DBLogin + ";pwd=" + DBPassword;
                GroupID = Convert.ToInt32(Properties.Settings.Default["ZabbixDBHostGroup"].ToString());
                MACSeparator = Convert.ToChar(Properties.Settings.Default["MACOctetSeparator"].ToString());
                Comunity = Properties.Settings.Default["Comunity"].ToString();

            }
            catch
            { stateFindFileSetting = false; }
            return (stateFindFileSetting);
        }


    }


}
