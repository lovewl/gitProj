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
    /// GetWxUnionID 的摘要说明
    /// </summary>
    public class GetWxUnionID : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            string token = Utility.ValidityAccessToken(context);
            string url = @"https://api.weixin.qq.com/cgi-bin/user/info?access_token=" + token + "&openid=" + "oSdTpt2qNdl2X1Oymz-k1IcDQdM4" + "&lang=zh_CN";
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