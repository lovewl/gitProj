using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wxtest.handlers
{
    /// <summary>
    /// award_activity 的摘要说明
    /// </summary>
    public class award_activity : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            string appid = "wx523e5529a4173607";
            string redirect_uri = HttpUtility.UrlEncode("http://222.41.193.142/UILayer/award-activity/answer/index.aspx");
            string scope = "snsapi_base";
            //string state = "A";
            string resultUrl = "https://open.weixin.qq.com/connect/oauth2/authorize?appid=" + appid + "&redirect_uri=" + redirect_uri + "&response_type=code&scope=" + scope + "&state=STATE#wechat_redirect";
            //context.Response.Redirect("https://open.weixin.qq.com/connect/oauth2/authorize?appid=APPID&redirect_uri=REDIRECT_URI&response_type=code&scope=SCOPE&state=STATE#wechat_redirect");
            context.Response.Redirect(resultUrl);
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