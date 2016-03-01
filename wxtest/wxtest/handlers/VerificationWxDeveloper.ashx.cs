using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using WxDev.BLL;
using WxDev.Model;
using WxDev.Utility;

namespace wxtest.handlers
{
    /// <summary>
    /// VerificationWxDeveloper 的摘要说明
    /// 验证开发者的一般处理程序
    /// </summary>
    public class VerificationWxDeveloper : IHttpHandler
    {
        private string token = "tokken1";
        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            if (context.Request.RequestType.ToLower().Equals("get"))
            {
                Verification(context);
            }
        }
        /// <summary>
        /// 验证开发者
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private bool Verification(HttpContext context)
        {
            string signature = context.Request.QueryString["signature"].ToString();
            string timestamp = context.Request.QueryString["timestamp"].ToString();
            string nonce = context.Request.QueryString["nonce"].ToString();
            string echostr = context.Request.QueryString["echostr"].ToString();

            string[] arrayStr = { token, timestamp, nonce };
            Array.Sort(arrayStr);

            string resultStr = string.Join("", arrayStr);
            resultStr = FormsAuthentication.HashPasswordForStoringInConfigFile(resultStr, "SHA1");
            if (signature.ToLower().Equals(resultStr.ToLower()))
            {
                context.Response.Write(echostr);
                return true;
            }
            else
            {
                return false;
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