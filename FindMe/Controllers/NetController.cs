using SnmpSharpNet;
using SwitchControl.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SwitchControl.Controllers
{
    class NetController
    {
        OctetString community;
        AgentParameters param;
        IpAddress agent;
        UdpTarget target;
        char octetSeparator;

        //private string patternSNMPWalk = "(1.3.6.1.2.1.17.7.1.2.2.1.2.1.)|((Integer32))";


        public NetController()
        {
            community = new OctetString(Properties.Settings.Default["Comunity"].ToString());
            param = new AgentParameters(community);
            param.Version = SnmpVersion.Ver2;
            octetSeparator = '-';
        }
        public NetController(string addr)
        {
            community = new OctetString(Properties.Settings.Default["Comunity"].ToString());
            param = new AgentParameters(community);
            param.Version = SnmpVersion.Ver2;
            agent = new IpAddress(addr);
            target = new UdpTarget((IPAddress)agent, 161, 2000, 1);
            octetSeparator = '-';
        }

        public void GetMacsOnPorts()
        {
            SNMPWalk("1.3.6.1.2.1.17.7.1.2.2.1.2.1");
        }

        public List<Host> SNMPWalk(string inOID)
        {
            List<Host> hosts = new List<Host>();

            Oid rootOid = new Oid(inOID);
            Oid lastOid = (Oid)rootOid.Clone();
            Pdu pdu = new Pdu(PduType.GetBulk);
            pdu.NonRepeaters = 0;
            pdu.MaxRepetitions = 5;
            while (lastOid != null)
            {
                if (pdu.RequestId != 0)
                {
                    pdu.RequestId += 1;
                }
                pdu.VbList.Clear();
                pdu.VbList.Add(lastOid);
                SnmpV2Packet result = (SnmpV2Packet)target.Request(pdu, param);
                if (result != null)
                {
                    if (result.Pdu.ErrorStatus != 0)
                    {
                        Console.WriteLine("Error in SNMP reply. Error {0} index {1}",
                            result.Pdu.ErrorStatus,
                            result.Pdu.ErrorIndex);
                        lastOid = null;
                        break;
                    }
                    else
                    {
                        foreach (Vb v in result.Pdu.VbList)
                        {
                            if (rootOid.IsRootOf(v.Oid))
                            {
                                string s = Regex.Replace(v.Oid.ToString(), "("+ inOID+ ".)|((Integer32))", String.Empty);
                                hosts.Add(new Host(v.Oid.ToString(), v.Value.ToString()));
                                Console.WriteLine("{0} ({1}): {2}",
                                    v.Oid.ToString(),
                                    SnmpConstants.GetTypeName(v.Value.Type),
                                    v.Value.ToString());
                                if (v.Value.Type == SnmpConstants.SMI_ENDOFMIBVIEW)
                                    lastOid = null;
                                else
                                    lastOid = v.Oid;
                            }
                            else
                            {
                                lastOid = null;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No response received from SNMP agent.");
                }
            }
            target.Close();

            return hosts;
        }




        public string DecMAC2Hex(string decMAC)
        {

            string pattern = "(OID=.1.3.6.1.2.1.17.7.1.2.2.1.2.1.)";
            string s ="", oct;

            foreach (string str2 in Regex.Split(decMAC, ", "))
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
                                ff += octetSeparator;
                            }
                            s = ff.Substring(0, ff.Length - 1);
                        }
                    }
                    //l.SubItems.Add(s);
                }

            }
            return (s);
        }

        public void ScanSubnets()
        {
            // ---------------- Скнировать подсети для наполнения кэша ARP. СДЕЛАТЬ В НАСТРОЙКАХ СПИСОК ПОДСЕТЕЙ!!!!!!
            Ping[] pingSender = new Ping[255];
            //Ping ping;
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 4000;
            //AutoResetEvent reset = new AutoResetEvent(false);
            //PingOptions options = new PingOptions(50, true);

            //string serv;
            //ping = new Ping();
            // Подсети с 8 по 14
            for (int k = 8; k < 15; k++)
                for (int i = 1; i < 255; i++)  // 255 хостов
                {
                    pingSender[i] = new Ping();
                    
                    pingSender[i].SendAsync("10.10." + k.ToString() + "." + i.ToString(), timeout, buffer);
                    //ping.SendAsync("10.10." + k.ToString() + "." + i.ToString(), timeout, buffer, options, reset);
                    //await ping.SendPingAsync("10.10." + k.ToString() + "." + i.ToString(), timeout, buffer, options);
                    // https://stackoverflow.com/questions/24158814/ping-sendasync-always-successful-even-if-client-is-not-pingable-in-cmd

                }

        }
    
    }

}
