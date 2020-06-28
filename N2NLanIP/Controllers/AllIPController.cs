using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N2NLanIP.Controllers
{
    public class AllIPController : ApiController
    {
        // GET api/allip
        public IEnumerable<string> Get()
        {
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "IP.txt"))
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "IP.txt", "");
            string[] lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "IP.txt");
            ArrayList al = new ArrayList();
            foreach (string l in lines)
            {
                if (!al.Contains(l))
                    al.Add(l);
            }
            string All = "";
            foreach (string l in al)
            {
                All += l + "\r\n";
            }
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "IP.txt", All);
            string[] arrString = (string[])al.ToArray(typeof(string));
            return arrString;
        }

        // GET api/allip/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/allip
        public void Post([FromBody]string value)
        {
        }

        // PUT api/allip/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/allip/5
        public void Delete(int id)
        {
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "IP.txt", "");
        }
    }
}
