using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Xml;
using wxtest.common;

namespace wxtest
{
    /// <summary>
    /// wxhandler 的摘要说明
    /// </summary>
    public class wxhandler : IHttpHandler
    {
        private string m_AccessToken = string.Empty;
        public static string Msg = "";
        public static string Token = string.Empty;
        public static string MediaID = string.Empty;
        public static string QRcodeImagePath = string.Empty;
        public static string WxUserOpenId = string.Empty;
        public static string WxDeveloperId = string.Empty;
        public static bool CardFlag = false;
        public void ProcessRequest(HttpContext context)
        {
            // 获取access_token
            m_AccessToken = Utility.ValidityAccessToken(context);
            Token = m_AccessToken;
            //MediaID = "Lwkw2loznZLh12m52Z1qzoAYATTphwiZ6YO5HXdZinpEv3dAFr-JgWma_gSanCoc";

            //context.Response.Write("<script language=\"javascript\">window.open('index.aspx','新窗口,\"toolbar=yes,location=no,directories=yes,status=yes,menubar=yes,resizable=yes,scrollbars=yes\");</script>");

            // 创建自定义菜单
            //CustomMenu.CreateMenu(context, m_AccessToken);

            // 查询素材列表
            //MaterialManagement.GetMaterialList(context, m_AccessToken);

            // 新增临时素材
            //MaterialManagement.CreateMaterialTemp(context, m_AccessToken);

            //Utility.GenerationQRcode(context, m_AccessToken);
            //string ticket = Utility.GenerationQRcode(context, m_AccessToken);
            //string ticket = "gQHc7zoAAAAAAAAAASxodHRwOi8vd2VpeGluLnFxLmNvbS9xL1ZreEV3dmpsa1c3b0FNTVF1MktOAAIES9EcVQMECAcAAA==";
            //context.Response.Write(ticket);
            //Utility.GetQRcodeImage(context, ticket);
            //ImagePath = "https://mmbiz.qlogo.cn/mmbiz/H0iamQmMhnBa7Mcv8GibicV7zicE8A5T5Kd2XmE3AZ1EIS8PGaIfvdLsVbiaa9tiaGPUrCL6TbXQOiaHpMBlZ2Pt8JHEQ/0";


            string postStr = "";
            if (context.Request.RequestType.ToLower().Equals("get"))
            {
                //Verification(context);
                if (HttpContext.Current != null && HttpContext.Current.Request != null && HttpContext.Current.Request.InputStream != null)
                {
                    using (Stream inputStream = HttpContext.Current.Request.InputStream)
                    {
                        byte[] buff = new byte[inputStream.Length];
                        inputStream.Read(buff, 0, (int)inputStream.Length);
                        string inputString = Encoding.UTF8.GetString(buff);
                        if (!string.IsNullOrEmpty(inputString))
                        {
                            XmlDocument xmlDoc = new XmlDocument();
                            xmlDoc.LoadXml(inputString);
                            XmlNodeList list = xmlDoc.GetElementsByTagName("xml");
                            if (list != null && list[0] != null)
                            {
                                XmlNode xn = list[0];
                                WxUserOpenId = xn.SelectSingleNode("FromUserName").InnerText;
                                WxDeveloperId = xn.SelectSingleNode("ToUserName").InnerText;
                            }
                        }
                    }
                }
            }
            else
            {
                Stream s = System.Web.HttpContext.Current.Request.InputStream;
                byte[] b = new byte[s.Length];
                s.Read(b, 0, (int)s.Length);
                postStr = Encoding.UTF8.GetString(b);
                if (!string.IsNullOrEmpty(postStr))
                {
                    // 接收处理消息
                    //context.Response.Write(cls_ReceiveMsg.ReceiveMsg(postStr, ref Msg, context, m_AccessToken));
                    string res = cls_ReceiveMsg.ReceiveMsg(m_AccessToken, postStr, ref Msg);
                    WxUserOpenId = cls_ReceiveMsg.OpenId;
                    WxDeveloperId = cls_ReceiveMsg.DeveloperId;
                    switch (cls_ReceiveMsg.EventType)
                    {
                        case "user_get_card":
                            //    if (CardFlag) break;
                            //    CardFlag = true;
                            //    string tmpStr = "{";
                            //    tmpStr += "\"touser\":\"" + WxUserOpenId + "\",";
                            //    tmpStr += "\"template_id\":\"" + "PISesU9zLSizCllkXwUzATScnq1-56RU8YrLU2y5VYc" + "\",";
                            //    tmpStr += "\"url\":\"http://mp.weixin.qq.com/s?__biz=MzAwMzAwMjAzNQ==&mid=401577783&idx=1&sn=59a41acb0a1fae9653477d75e850292d#rd\",";
                            //    tmpStr += "\"data\":{";
                            //    tmpStr += "\"first\":{";
                            //    tmpStr += "\"value\":\"尊敬的客户：\n尊敬的车主，您已经成功领取卡券，我们的客服会联系您，请你保持手机畅通。\",";
                            //    tmpStr += "\"color\":\"#173177\"";
                            //    tmpStr += "},";
                            //    tmpStr += "\"keynote1\":{";
                            //    tmpStr += "\"value\":\"待确认\",";
                            //    tmpStr += "\"color\":\"#173177\"";
                            //    tmpStr += "},";
                            //    tmpStr += "\"keynote2\":{";
                            //    tmpStr += "\"value\":\"18192933995\",";
                            //    tmpStr += "\"color\":\"#173177\"";
                            //    tmpStr += "},";
                            //    tmpStr += "\"keynote3\":{";
                            //    tmpStr += "\"value\":\"yj86220693\",";
                            //    tmpStr += "\"color\":\"#173177\"";
                            //    tmpStr += "},";
                            //    tmpStr += "\"remark\":{";
                            //    tmpStr += "\"value\":\"新春钣喷特惠\",";
                            //    tmpStr += "\"color\":\"#173177\"";
                            //    tmpStr += "}";
                            //    tmpStr += "}";
                            //    tmpStr += "}";
                            //    byte[] buf = Encoding.UTF8.GetBytes(tmpStr);
                            //    string url = "https://api.weixin.qq.com/cgi-bin/message/template/send?access_token=" + m_AccessToken;
                            //    HttpWebRequest httpReq = WebRequest.Create(url) as HttpWebRequest;
                            //    httpReq.Method = "POST";
                            //    using (Stream s1 = httpReq.GetRequestStream())
                            //    {
                            //        s1.Write(buf, 0, buf.Length);
                            //        s1.Close();
                            //        using (HttpWebResponse myResponse = httpReq.GetResponse() as HttpWebResponse)
                            //        {
                            //            //using (StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8))
                            //            //{
                            //            //    string content = reader.ReadToEnd();
                            //            //    Response.Write(content);
                            //            //}
                            //        }
                            //    }
                            break;
                    }
                    context.Response.Write(res);
                }
            }
            //context.Response.Redirect("index.aspx");

            //if (context.Request.RequestType.ToLower().Equals("get"))
            //{
            //    Verification(context);
            //}
        }

        public string GetPage(string posturl, string postData, HttpContext context)
        {
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
                CookieContainer cookieContainer = new CookieContainer();
                request.CookieContainer = cookieContainer;
                request.AllowAutoRedirect = true;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
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
                string err = string.Empty;
                return content;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                context.Response.Write(err);
                return string.Empty;
            }
        }
        // 验证开发者
        private bool Verification(HttpContext context)
        {
            string token = "tokken11aks11yongjiu";
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