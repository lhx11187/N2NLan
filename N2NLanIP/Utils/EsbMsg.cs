using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using Newtonsoft.Json;

namespace mdc.Api.Utils
{
    [Serializable]
    public class EsbReqMsg
    {
        /// <summary>
        /// EsbHeader
        /// </summary>
        public EsbReqHeader EsbReqHeader { get; set; }

        /// <summary>
        /// EsbData
        /// </summary>
        public object EsbReqData { get; set; }
    }

    [Serializable]
    public class EsbReqHeader
    {
        /// <summary>
        /// RequestId
        /// </summary>
        public string RequestId { get; set; }
        /// <summary>
        /// SourceSystem
        /// </summary>
        public string SourceSystem { get; set; }
        /// <summary>
        /// TargetSystem
        /// </summary>
        public string TargetSystem { get; set; }
        /// <summary>
        /// ServiceName
        /// </summary>
        public string ServiceName { get; set; }
        /// <summary>
        /// ServiceOperation
        /// </summary>
        public string ServiceOperation { get; set; }
        /// <summary>
        /// ServiceVersion
        /// </summary>
        public string ServiceVersion { get; set; }
    }
    public class EsbPost
    {
        /// <summary>
        /// 调用接口
        /// </summary>
        /// <param name="posturl"></param>
        /// <param name="postData"></param>
        /// <returns></returns>
        public string PostMsg(string posturl, string postData,out string errMsg)
        {
            errMsg = string.Empty;
            Stream outstream = null;
            Stream instream = null;
            StreamReader sr = null;
            HttpWebResponse response = null;
            HttpWebRequest request = null;
            Encoding encoding = Encoding.UTF8;
            byte[] data = encoding.GetBytes(postData);
            // 准备请求...
            try
            {
                // 设置参数
                request = WebRequest.Create(posturl) as HttpWebRequest;
                request.Timeout = 5000000;
                request.ReadWriteTimeout = 5000000;
                //request.Headers.Add(HttpRequestHeader.Authorization, userInfo);
                CookieContainer cookieContainer = new CookieContainer();
                request.CookieContainer = cookieContainer;
                request.AllowAutoRedirect = true;
                request.Method = "POST";
                request.ContentType = "application/json";
                request.ContentLength = data.Length;
                outstream = request.GetRequestStream();
                outstream.Write(data, 0, data.Length);
                outstream.Close();

                //发送请求并获取相应回应数据
                response = request.GetResponse() as HttpWebResponse;
                //直到request.GetResponse()程序才开始向目标网页发送Post请求
                instream = response.GetResponseStream();
                sr = new StreamReader(instream, encoding);
                //返回结果网页（html）代码
                string content = sr.ReadToEnd();

                return content;
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
                return string.Empty;
            }
        }
    }

}

