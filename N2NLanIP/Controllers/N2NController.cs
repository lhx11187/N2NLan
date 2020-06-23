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
            /*
            SQLhelper sh = new SQLhelper();
            DataTable dt = sh.DataTableQuery("SELECT top 1 Local_IP FROM IP order by Local_IP DESC");
            string IP = dt.Rows[0][0].ToString();
            */
            if(!File.Exists(AppDomain.CurrentDomain.BaseDirectory+"IP.txt"))
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "IP.txt", "");
            string[] lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "IP.txt");
            Int32 max2 = 0;
            Int32 max3 = 0;
            //ArrayList al = new ArrayList();
            foreach (string l in lines)
            {
                string[] ips = l.Split('.');
                if (Convert.ToInt32(ips[2]) > max2)
                    max2 = Convert.ToInt32(ips[2]);
                //al.Add(l); 
            }
            foreach (string l in lines)
            {
                string[] ips = l.Split('.');
                if (Convert.ToInt32(ips[2])==max2)
                    if (Convert.ToInt32(ips[3]) > max3)
                        max3 = Convert.ToInt32(ips[3]);
            }
            string IP = "10.10." + max2.ToString() + "." + max3.ToString();
            string[] ipss = IP.Split('.');
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
            File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "IP.txt", IPnew + "\r\n");
            //sh.ExecuteNonQuery("insert into IP (Local_IP) values ('" + IPnew + "')");
            return IPnew;
        }

        // GET api/N2N/250
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public string Post([FromBody]string value)
        {
            string IPnew = value.Trim().Replace("\"", "").Replace("\r", "").Replace("\n", "").Replace("\t", "");
            if (!String.IsNullOrWhiteSpace(IPnew))
            {
                if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "IP.txt"))
                    File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "IP.txt", "");
                File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "IP.txt", IPnew + "\r\n");
                //SQLhelper sh = new SQLhelper();
                //sh.ExecuteNonQuery("insert into IP (Local_IP) values ('" + IPnew + "')");
            }
            return IPnew;
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
                if (l != value)
                {
                    all+=l+"\r\n";
                }
            }
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "IP.txt", all);
        }
    }
}