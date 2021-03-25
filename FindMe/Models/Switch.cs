using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchControl.Models
{
    // Список хостов в гриде слева
    class Switch
    {
        private string host;
        private string name;
        private string ip;
        private string macaddress_a;
        private string online;
        private string inPorts;

        public string HostHost
        {
            get { return host; }
            set { host = value; }
        }
        public string HostName
        {
            get { return name; }
            set { name = value; }
        }
        public string HostIp
        {
            get { return ip; }
            set { ip = value; }
        }
        public string HostMAC
        {
            get { return macaddress_a; }
            set { macaddress_a = value; }
        }
        public string HostOnline
        {
            get { return online; }
            set { online = value; }
        }
        public string HostInPorts
        {
            get { return inPorts; }
            set { inPorts = value; }
        }

    }
    // хост - парсинг arp
    class Host2
    {
        public string ip;
        public string macaddress;
    }
}
