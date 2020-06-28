using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N2NLanIP.Controllers
{
    public class VersionController : ApiController
    {
        // GET api/Version
        public string Get()
        {
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Version.txt"))
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "Version.txt", "");
            string Version = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Version.txt");

            return Version;
        }
        // GET api/Version/id
        public string Get(string Version)
        {
            Version = Version.Trim().Replace("\"", "").Replace("\r", "").Replace("\n", "").Replace("\t", "");
            if (!String.IsNullOrWhiteSpace(Version))
            {
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "Version.txt", Version);
            }
            return Version;
        }
        // POST api/values
        public string Post([FromBody]string value)
        {
            string Version = value.Trim().Replace("\"", "").Replace("\r", "").Replace("\n", "").Replace("\t", "");
            if (!String.IsNullOrWhiteSpace(Version))
            {
                 File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "Version.txt", Version);
            }
            return Version;
        }
    }
}
