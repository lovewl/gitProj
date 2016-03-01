using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using wxtest.common;

namespace wxtest.UILayer.MetalPlate
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected string OpenID { get; set; }
        protected string DeveloperID { get; set; }
        protected ViewModel.WxUserInfoView UserInfo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            string m_AccessToken = Utility.ValidityAccessToken(HttpContext.Current);
            if (Request.Cookies["wxuseropenid"] != null && !string.IsNullOrEmpty(Request.Cookies["wxuseropenid"].Value))
            {
                OpenID = Request.Cookies["wxuseropenid"].Value;
            }
            else
            {
                OpenID = wxhandler.WxUserOpenId;
                HttpCookie cookie = new HttpCookie("wxuseropenid");
                cookie.Value = OpenID;
                HttpContext.Current.Response.Cookies.Add(cookie);
            }
            //string wxOpenId = "", wxDeveloperId = "";
            //string testTMP = "";
            //string userOpen = wxhandler.UserOpenId;
            ////string userOpen2 = HttpContext.Current.Request.Cookies["wxcookie"].Value;
            //testTMP += "<br />" + userOpen;
            ////testTMP += "<br />" + userOpen2;
            //foreach (var item in Request.Cookies.AllKeys)
            //{
            //    testTMP += "<br />" + item.ToString();
            //}
            ////foreach (var item in Request.Params)
            ////{
            ////    testTMP += "<br />" + item.ToString();
            ////}
            //Response.Write(testTMP);
            //Response.End();
            //var req = Request.Params;

            //if (Request.Cookies["wxOpenId"] != null)
            //{
            //    wxOpenId = Request.Cookies["wxOpenId"].Value;
            //}
            //if (Request.Cookies["wxcookie"] != null)
            //{
            //    wxOpenId = Request.Cookies["wxcookie"].Value;
            //}
            //Response.Write("wxOpenId:" + cls_ReceiveMsg.wxOpenId);
            //Response.End();
            //else
            //{
            //    wxOpenId = "oSdTpt2qNdl2X1Oymz-k1IcDQdM4";
            //}
            //if (Request.Cookies["wxDeveloperId"] != null)
            //{
            //    wxDeveloperId = Request.Cookies["wxDeveloperId"].Value;
            //}
            //if (!string.IsNullOrEmpty(wxOpenId))
            //{
            //    //wxOpenId = "osyz-stYsuJ-lOqKY6loaQ0caO4c";
            //    wxOpenId = "osyz-svEyXPp2lWw_SlZSM85OcNY";
            //    string url = "https://api.weixin.qq.com/cgi-bin/user/info?access_token=" + m_AccessToken + "&openid=" + wxOpenId + "&lang=zh_CN";
            //    //string url = "https://api.weixin.qq.com/cgi-bin/user/get?access_token=" + m_AccessToken + "&next_openid=";
            //    HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            //    request.Method = "GET";
            //    using (WebResponse response = request.GetResponse())
            //    {
            //        using (StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            //        {
            //            var res = sr.ReadToEnd();
            //            UserInfo = Newtonsoft.Json.JsonConvert.DeserializeObject<ViewModel.WxUserInfoView>(res);
            //        }
            //    }
            //}

            if (!string.IsNullOrEmpty(wxhandler.WxUserOpenId))
            {
                OpenID = wxhandler.WxUserOpenId;
                HttpCookie cookie = new HttpCookie("wxuseropenid");
                cookie.Value = OpenID;
                cookie.Expires = DateTime.Now.AddDays(1.0);
                HttpContext.Current.Response.Cookies.Add(cookie);
            }
            if (!string.IsNullOrEmpty(wxhandler.WxDeveloperId))
            {
                DeveloperID = wxhandler.WxDeveloperId;
                HttpCookie cookie = new HttpCookie("wxdeveloperid");
                cookie.Value = DeveloperID;
                cookie.Expires = DateTime.Now.AddDays(1.0);
                HttpContext.Current.Response.Cookies.Add(cookie);
            }
            if (!string.IsNullOrEmpty(OpenID))
            {
                string tmpStr = "{";
                tmpStr += "\"touser\":\"" + OpenID + "\",";
                tmpStr += "\"template_id\":\"" + "PISesU9zLSizCllkXwUzATScnq1-56RU8YrLU2y5VYc" + "\",";
                tmpStr += "\"url\":\"http://222.41.193.142/UILayer/MetalPlate/index.aspx\",";
                tmpStr += "\"data\":{";
                tmpStr += "\"first\":{";
                tmpStr += "\"value\":\"恭喜你预约成功!\",";
                tmpStr += "\"color\":\"#173177\"";
                tmpStr += "},";
                tmpStr += "\"keynote1\":{";
                tmpStr += "\"value\":\"" + DateTime.Now.AddDays(1.0) + "\",";
                tmpStr += "\"color\":\"#173177\"";
                tmpStr += "},";
                tmpStr += "\"keynote2\":{";
                tmpStr += "\"value\":\"02986220693\",";
                tmpStr += "\"color\":\"#173177\"";
                tmpStr += "},";
                tmpStr += "\"keynote3\":{";
                tmpStr += "\"value\":\"-\",";
                tmpStr += "\"color\":\"#173177\"";
                tmpStr += "},";
                tmpStr += "\"remark\":{";
                tmpStr += "\"value\":\"欢迎再次预约！\",";
                tmpStr += "\"color\":\"#173177\"";
                tmpStr += "}";
                tmpStr += "}";
                tmpStr += "}";
                byte[] buf = Encoding.UTF8.GetBytes(tmpStr);
                string url = "https://api.weixin.qq.com/cgi-bin/message/template/send?access_token=" + m_AccessToken;
                HttpWebRequest httpReq = WebRequest.Create(url) as HttpWebRequest;
                httpReq.Method = "POST";
                using (Stream s = httpReq.GetRequestStream())
                {
                    s.Write(buf, 0, buf.Length);
                    s.Close();
                    using (HttpWebResponse myResponse = httpReq.GetResponse() as HttpWebResponse)
                    {
                        //using (StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8))
                        //{
                        //    string content = reader.ReadToEnd();
                        //    Response.Write(content);
                        //}
                    }
                }
            }

            if (Request.IsPostBack())
            {
                var aaa1 = Request["aaa"];
                var aaa2 = Request["mmm"];
                var aaa3 = Request["txt01"];
                var aaa4 = Request["file01"];
                var aaa5 = Request.Files["file01"];
                var fileInfo1 = Request["file01"];
                var fileInfo2 = Request.Files["file01"];
                var fileInfo3 = Request["form01"];
                var fileInfo4 = Request.Form["form01"];
                var fileInfo5 = Request["form01"];
            }
        }
    }
}