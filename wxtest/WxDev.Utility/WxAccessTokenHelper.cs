using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace WxDev.Utility
{
    public static class WxAccessTokenHelper
    {
        private static string appid = "wx51295c590339fdd5";
        private static string secret = "bd23afaee890e7c3cc8f2e0327934870";
        public static string GetAccessToken(HttpContext context)
        {
            string reqUri = "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid=" + appid + "&secret=" + secret;
            HttpWebRequest request = HttpWebRequest.Create(reqUri) as HttpWebRequest;
            request.Method = "GET";
            using  (HttpWebResponse res = request.GetResponse() as HttpWebResponse)
            {
                using (StreamReader sr = new StreamReader(res.GetResponseStream()))
                {
                    string content = sr.ReadToEnd();
                    sr.Close();
                    return content;
                }
            }
        }
    }
}
