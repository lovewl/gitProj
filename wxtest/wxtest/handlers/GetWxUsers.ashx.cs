using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using wxtest.common;

namespace wxtest.handlers
{
    /// <summary>
    /// GetWxUsers 的摘要说明
    /// </summary>
    public class GetWxUsers : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            string token = Utility.ValidityAccessToken(context);
            string url = @"https://api.weixin.qq.com/cgi-bin/user/get?access_token=" + token;
            HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;
            request.Method = "GET";
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                using (StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    string content = sr.ReadToEnd();
                    context.Response.Write(content);
                }
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}