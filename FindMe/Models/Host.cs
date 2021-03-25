using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchControl.Models
{
    class Host
    {
        private string ip;
        private string mac;
        int switch_id;
        string switch_name;
        int port;



        public Host(string hostIP, string hostMAC)
        {
            ip = hostIP;
            mac = hostMAC;
        }


        public string HostMAC
        {
            get { return mac; }
            set { mac = value; }
        }


        public string HostIp
        {
            get { return ip; }
            set { ip = value; }
        }


    }
}
