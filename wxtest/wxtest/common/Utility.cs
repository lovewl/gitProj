using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using wxtest.Model;

namespace wxtest.common
{
    /// <summary>
    /// 工具类
    /// </summary>
    public class Utility
    {
        public static string GenerationQRcode(HttpContext context, string token)
        {
            string strUrl = @"https://api.weixin.qq.com/cgi-bin/qrcode/create?access_token=" + token;
            byte[] bytes = Encoding.UTF8.GetBytes(GetQRcodeParam());
            HttpWebRequest request = HttpWebRequest.Create(strUrl) as HttpWebRequest;
            request.Method = "POST";
            QRcodeTicket qrCode = new QRcodeTicket();
            using (Stream sendStream = request.GetRequestStream())
            {
                // 写入附加参数
                sendStream.Write(bytes, 0, bytes.Length);
                // 关闭流
                sendStream.Close();
                using (HttpWebResponse myResponse = request.GetResponse() as HttpWebResponse)
                {
                    using (StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8))
                    {
                        string content = reader.ReadToEnd();
                        JavaScriptSerializer js = new JavaScriptSerializer();
                        qrCode = js.Deserialize<QRcodeTicket>(content);
                        context.Response.Write(content);
                        context.Response.Write("------------------------");
                        context.Response.Write("qrCode.Ticek : " + qrCode.Ticket + "----qrCode.Expire_seconds : " + qrCode.Expire_seconds + "----qrCode.Url : " + qrCode.Url);
                        //return content;
                    }
                }
            }
            return qrCode.Ticket;
        }
        private static string GetQRcodeParam()
        {
            string QRStr = string.Empty;
            //{"expire_seconds": 1800, "action_name": "QR_SCENE", "action_info": {"scene": {"scene_id": 123}}}
            QRStr += "{\"expire_seconds\": 1800, \"action_name\": \"QR_SCENE\", \"action_info\": {\"scene\": {\"scene_id\":shanxiyongjiu}}}";

            return QRStr;
        }
        public static string GetQRcodeImage(HttpContext context, string ticket)
        {
            //StringBuilder sb = new StringBuilder();
            //byte[] byStr = System.Text.Encoding.UTF8.GetBytes(ticket); //默认是System.Text.Encoding.Default.GetBytes(str)
            //for (int i = 0; i < byStr.Length; i++)
            //{
            //    sb.Append(@"%" + Convert.ToString(byStr[i], 16));
            //}
            //ticket = sb.ToString();
            ticket = HttpUtility.UrlEncode(ticket);
            context.Response.Write(ticket + "----ticket----content----");
            string strUrl = "https://mp.weixin.qq.com/cgi-bin/showqrcode?ticket=" + ticket;
            HttpWebRequest request = HttpWebRequest.Create(strUrl) as HttpWebRequest;
            request.Method = "GET";
            using (HttpWebResponse myResponse = request.GetResponse() as HttpWebResponse)
            {
                string path = myResponse.ResponseUri.ToString();
                wxhandler.QRcodeImagePath = path;
                WebClient wclient = new WebClient();
                //wclient.DownloadFile(path, context.Server.MapPath("/aaa.jpg"));   //下载文件到指定路径
                
                //context.Response.Redirect(path);
                //WebClient mywebclient = new WebClient();
                using (StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8))
                {
                    string content = reader.ReadToEnd();
                    return content;
                    //context.Response.Write(content);
                    //context.Response.End();
                }
            }
        }
        /// <summary>
        /// 验证access_token是否过期，如果过期则获取新的token，并返回当前可用的access_token
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static string ValidityAccessToken(HttpContext context)
        {
            DBAccessToken dbToken = Sqlhelper.GetDBAccessToken();
            string accessToken = string.Empty;
            if (DateTime.Now > dbToken.CheckTime)
            {
                Access_Token token = GetAccessToken(context);
                if (token != null)
                {
                    dbToken.AccessToken = token.access_token;
                    dbToken.CheckTime = DateTime.Now.AddSeconds(Convert.ToDouble(token.expires_in));
                    dbToken.ExpiresIn = token.expires_in;
                    Sqlhelper.UpDateDBAccessToken(dbToken);
                    //context.Response.Write("更新成功");
                }
                else
                {
                    //context.Response.Write("没有更新");
                }
            }
            else
            {
                //context.Response.Write("没有更新");
            }
            return accessToken = dbToken.AccessToken;
        }
        /// <summary>
        /// 从微信服务器获取access_token信息
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private static Access_Token GetAccessToken(HttpContext context)
        {
            string strUrl = "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid=wx523e5529a4173607&secret=880782eed53f677edabf18c32cc2ab4c";
            Access_Token token = new Access_Token();
            HttpWebRequest req = HttpWebRequest.Create(strUrl) as HttpWebRequest;
            req.Method = "GET";
            using (HttpWebResponse myResponse = req.GetResponse() as HttpWebResponse)
            {
                using (StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8))
                {
                    string content = reader.ReadToEnd();
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    token = js.Deserialize<Access_Token>(content);
                    return token;
                }
            }
        }
        //// 获取access_token
        //private string Get_Access_token()
        //{
        //    WebClient webclient = new WebClient();
        //    string url = @"https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid=wx51295c590339fdd5&secret=bd23afaee890e7c3cc8f2e0327934870";
        //    byte[] bytes = webclient.DownloadData(url);//在指定的path上下载
        //    string result = Encoding.GetEncoding("utf-8").GetString(bytes);//转string
        //    JavaScriptSerializer js = new JavaScriptSerializer();
        //    Access_Token amodel = js.Deserialize<Access_Token>(result);//此处为定义的类，用以将json转成model
        //    string a_token = amodel.access_token;
        //    return a_token;
        //}
        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="context"></param>
        /// <param name="urlStr"></param>
        public static void DownloadFile(HttpContext context, string urlStr)
        {
            // 下载文件
            string remoteUri = urlStr;
            string fileName = string.Empty;
            string[] tmp1 = urlStr.Split('/');
            string[] tmp2 = tmp1[tmp1.Length - 1].Split('.');
            // 根据文件后缀分类
            switch (tmp2[tmp2.Length - 1].ToLower())
            {
                case "tiff":
                case "tga":
                case "exif":
                case "fpx":
                case "svg":
                case "cdr":
                case "pcd":
                case "dxf":
                case "ufo":
                case "eps":
                case "ai":
                case "hdr":
                case "tif":
                case "raw":
                case "psd":
                case "png":
                case "bmp":
                case "jpeg":
                case "gif":
                case "jpg":
                    fileName = context.Server.MapPath("/images/") + tmp1[tmp1.Length - 1];
                    break;
                default:
                    fileName = context.Server.MapPath("/temp/") + tmp1[tmp1.Length - 1];
                    break;
            }
            // 创建一个WebClient实例，用来下载文件
            WebClient myWebClient = new WebClient();
            myWebClient.DownloadFile(remoteUri, fileName);
        }
    }
}