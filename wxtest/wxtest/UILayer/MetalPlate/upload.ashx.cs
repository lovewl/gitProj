using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wxtest.UILayer.MetalPlate
{
    /// <summary>
    /// upload 的摘要说明
    /// </summary>
    public class upload : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            var aaa1 = context.Request["aaa"];
            var aaa2 = context.Request["mmm"];
            var aaa3 = context.Request["txt01"];
            var aaa4 = context.Request["txt02"];
            var aaa5 = context.Request.Files["file01"];
            var aaa6 = context.Request.Files["file02"];
            var aaa9 = context.Request["aaa"];


            //var fileInfo = context.Request["captureFile1"];
            //var files = context.Request.Files;


            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
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