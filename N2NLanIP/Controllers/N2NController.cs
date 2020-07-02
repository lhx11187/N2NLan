using N2NLanIP.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N2NLanIP.Controllers
{
    public class N2NController : ApiController
    {
        // GET api/N2N
        public string Get()
        {
            if(!File.Exists(AppDomain.CurrentDomain.BaseDirectory+"IP.txt"))
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "IP.txt", "");
            string[] lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "IP.txt");
            Int32 max2 = 0;
            Int32 max3 = 0;
            //ArrayList al = new ArrayList();
            foreach (string l in lines)
            {
                string IPtemp = l.Split(',')[1];
                string[] ips = IPtemp.Split('.');
                if (Convert.ToInt32(ips[2]) > max2)
                    max2 = Convert.ToInt32(ips[2]);
                //al.Add(l); 
            }
            foreach (string l in lines)
            {
                string IPtemp = l.Split(',')[1];
                string[] ips = IPtemp.Split('.');
                if (Convert.ToInt32(ips[2])==max2)
                    if (Convert.ToInt32(ips[3]) > max3)
                        max3 = Convert.ToInt32(ips[3]);
            }
            string MAXIP = "10.10." + max2.ToString() + "." + max3.ToString();
            string[] ipss = MAXIP.Split('.');
            if (Convert.ToInt32(ipss[3]) < 254)
                ipss[3]=(Convert.ToInt32(ipss[3])+1).ToString();
            else
            {
                if (Convert.ToInt32(ipss[2]) < 254)
                {
                    ipss[2] = (Convert.ToInt32(ipss[2]) + 1).ToString();
                    ipss[3] = "1";
                }
            }
            string IPnew = String.Join(".",ipss);
            //File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "IP.txt", IPnew + "\r\n");
            return IPnew;
        }

        // GET api/N2N/250
        public string Get(string id)
        {
            id = id.ToUpper();
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "IP.txt"))
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "IP.txt", "");
            string[] lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "IP.txt");

            foreach (string l in lines)
            {
                if (l.Contains(id))
                    return l.Split(',')[1];
            }
            string IPnew = Get();
            File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "IP.txt", id + "," + IPnew + "\r\n");
            return IPnew;
        }

        // POST api/N2N/values
        public string Post([FromBody]string value)
        {
            string valuenew = value.Trim().ToUpper().Replace("\"", "").Replace("\r", "").Replace("\n", "").Replace("\t", "");
            if (!String.IsNullOrWhiteSpace(valuenew) && valuenew.Contains(","))
            {
                if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "IP.txt"))
                    File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "IP.txt", "");
                string StrAll=File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "IP.txt");
                if (!StrAll.Contains(value))
                    if (!StrAll.Contains(value.Split(',')[0]))
                        File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "IP.txt", valuenew + "\r\n");
                    else 
                    {
                        string[] lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "IP.txt");
                        string All = "";
                        foreach (string l in lines)
                        {
                            if (l.Contains(value.Split(',')[0]))
                                All += value + "\r\n";
                            All += l + "\r\n";
                        }
                        File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "IP.txt", All);
                    }
            }
            return valuenew;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete([FromBody]string value)
        {
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "IP.txt"))
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "IP.txt", "");
            string[] lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "IP.txt");
            string all="";
            foreach (string l in lines)
            {
                string CPUID = l.Split(',')[0];
                if (CPUID.Trim().ToUpper() != value.ToUpper())
                {
                    all+=l+"\r\n";
                }
            }
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "IP.txt", all);
        }
    }
}