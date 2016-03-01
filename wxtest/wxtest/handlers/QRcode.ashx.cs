using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using wxtest.common;

namespace wxtest.handlers
{
    /// <summary>
    /// QRcode 的摘要说明
    /// </summary>
    public class QRcode : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string token = Utility.ValidityAccessToken(context);            
            string ticket = Utility.GenerationQRcode(context, token);
            string img = Utility.GetQRcodeImage(context, ticket);
            context.Response.ContentType = "image/jpeg";
            context.Response.Write(img);
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