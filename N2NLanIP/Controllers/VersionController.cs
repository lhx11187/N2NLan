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
    }
}
