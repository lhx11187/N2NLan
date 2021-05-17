using N2NLanIP.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace N2NLanIP.Controllers
{
    public class NoticeController : ApiController
    {
        // GET api/notice
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/notice/5
        public string Get(string mailSubjct, string mailBody, string mailto)
        {
            string errmsg=MailHelper.sendMail(mailSubjct, mailBody, mailto);
            return errmsg;
        }

        // POST api/notice
        public string Post([FromBody]object value)
        {
            JObject j = (JObject)JsonConvert.DeserializeObject(value.ToString());
            string mailSubjct = j["mailSubjct"].ToString();
            string mailBody = j["mailBody"].ToString();
            string mailTo = j["mailTo"].ToString();
            string mailFrom = j["mailFrom"].ToString();
            string errmsg = "";
            if (string.IsNullOrWhiteSpace(mailFrom))
                errmsg = MailHelper.sendMail(mailSubjct, mailBody, mailTo);
            else
                errmsg = MailHelper.sendMail(mailSubjct, mailBody, mailFrom, mailTo);
            return errmsg;
        }

        // PUT api/notice/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/notice/5
        public void Delete(int id)
        {
        }
    }
}
