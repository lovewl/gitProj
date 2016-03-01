using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml;

namespace wxtest.common
{
    public static class cls_ReceiveMsg
    {
        public static string OpenId { get; set; }
        public static string DeveloperId { get; set; }
        public static string EventType { get; set; }
        // 按XML解析数据
        private static XmlNode Parsing(string postMsg)
        {
            if (string.IsNullOrEmpty(postMsg)) return null;
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(postMsg);
            XmlNodeList list = doc.GetElementsByTagName("xml");

            return list[0];
        }
        // 验证活动回复消息
        private static bool Festivalactivities(string Str)
        {
            var strList = Str.Split('+');
            if (strList.Length != 2) return false;
            Regex reg = new Regex(@"1\d{10}");
            if (string.IsNullOrWhiteSpace(reg.Match(strList[1]).ToString())) return false;
            return true;
        }
        // 普通消息处理函数
        public static string ReceiveMsg(string accesstoken, string postMsg, ref string Msg)
        {
            XmlNode xn = Parsing(postMsg);
            string FromUserName = xn.SelectSingleNode("FromUserName").InnerText;    // 得到发消息用户的OpenID
            string ToUserName = xn.SelectSingleNode("ToUserName").InnerText;        // 开发者微信号
            string CreateTime = xn.SelectSingleNode("CreateTime").InnerText;        // 消息创建时间
            string MsgType = xn.SelectSingleNode("MsgType").InnerText;              // 消息类型
            string strResult = string.Empty;
            string strResponse = string.Empty;
            OpenId = FromUserName;
            DeveloperId = ToUserName;

            switch (MsgType)
            {
                case "text":    // 文本消息
                    {
                        string content = xn.SelectSingleNode("Content").InnerText;
                        string MsgId = xn.SelectSingleNode("MsgId").InnerText;      // 消息id，64位整型
                        // 显示的内容
                        strResult += "你好\n";
                        strResult += "FromUserName:" + FromUserName + "\n";
                        strResult += "ToUserName:" + ToUserName + "\n";
                        strResult += "CreateTime:" + CreateTime + "\n";
                        strResult += "MsgType:" + MsgType + "\n";
                        strResult += "Content:" + content + "\n";
                        strResult += "MsgId:" + MsgId + "\n";
                        switch (content)
                        {
                            case "端午节":
                                strResponse += "<xml>";
                                strResponse += "<ToUserName><![CDATA[" + FromUserName + "]]></ToUserName>";
                                strResponse += "<FromUserName><![CDATA[" + ToUserName + "]]></FromUserName>";
                                strResponse += "<CreateTime>" + DateTime.Now.Ticks.ToString() + "</CreateTime>";
                                strResponse += "<MsgType><![CDATA[news]]></MsgType>";
                                strResponse += "<ArticleCount>1</ArticleCount>";
                                strResponse += "<Articles>";
                                strResponse += "<item>";
                                strResponse += "<Title><![CDATA[端午节送福利了！]]></Title>";
                                strResponse += "<Description><![CDATA[端午节送福利了！！！凡6月18日-30日期间进店的客户，可享受多重优惠！]]></Description>";
                                strResponse += "<PicUrl><![CDATA[https://mmbiz.qlogo.cn/mmbiz/qfBeGNVpnqvv27VthEibyyN0b0TrNnSaYdgugAiaT6WloO7WRwVcPm2DpQwBydsqEFb7hPgQ07Ll4I2iacP36a0gw/0?wx_fmt=jpeg]]></PicUrl>";
                                strResponse += "<Url><![CDATA[http://mp.weixin.qq.com/s?__biz=MzAwMzAwMjAzNQ==&mid=209227554&idx=1&sn=1db60ebe29404adb74a36e6d9e49e489#rd]]></Url>";
                                strResponse += "</item>";
                                strResponse += "</Articles>";
                                strResponse += "</xml>";
                                break;
                            //case "99":
                            //    strResponse += "<xml>";
                            //    strResponse += "<ToUserName><![CDATA[" + FromUserName + "]]></ToUserName>";
                            //    strResponse += "<FromUserName><![CDATA[" + ToUserName + "]]></FromUserName>";
                            //    strResponse += "<CreateTime>" + DateTime.Now.Ticks.ToString() + "</CreateTime>";
                            //    strResponse += "<MsgType><![CDATA[text]]></MsgType>";
                            //    //strResponse += "<Content><![CDATA[" + strResult + "]]></Content>";
                            //    strResponse += "<Content><![CDATA[欢迎您参加99元车漆快修活动\n请按照以下格式再次回复：\n姓名+车型+车号+电话\n信息之间保留“+”，否则无法正常收到卡券，感谢合作!!!]]></Content>";
                            //    strResponse += "</xml>";
                            //    break;
                            case "288":
                                strResponse += "<xml>";
                                strResponse += "<ToUserName><![CDATA[" + FromUserName + "]]></ToUserName>";
                                strResponse += "<FromUserName><![CDATA[" + ToUserName + "]]></FromUserName>";
                                strResponse += "<CreateTime>" + DateTime.Now.Ticks.ToString() + "</CreateTime>";
                                strResponse += "<MsgType><![CDATA[text]]></MsgType>";
                                //strResponse += "<Content><![CDATA[" + strResult + "]]></Content>";
                                strResponse += "<Content><![CDATA[欢迎您参加新年特惠活动\n请按照以下格式再次回复：\n车型+电话\n信息之间保留“+”，否则无法正常收到卡券，感谢合作!!!]]></Content>";
                                strResponse += "</xml>";
                                break;
                            default:
                                //if (Festivalactivities(content))
                                //{
                                //    strResponse += "<xml>";
                                //    strResponse += "<ToUserName><![CDATA[" + FromUserName + "]]></ToUserName>";
                                //    strResponse += "<FromUserName><![CDATA[" + ToUserName + "]]></FromUserName>";
                                //    strResponse += "<CreateTime> " + DateTime.Now.Ticks.ToString() + " </CreateTime>";
                                //    strResponse += "<MsgType><![CDATA[news]]></MsgType>";
                                //    strResponse += "<ArticleCount>1</ArticleCount>";
                                //    strResponse += "<Articles>";
                                //    strResponse += "<item>";
                                //    strResponse += "<Title><![CDATA[99元喷漆]]></Title>";
                                //    strResponse += "<Description><![CDATA[99元喷漆活动卡券]]></Description>";
                                //    strResponse += "<PicUrl><![CDATA[https://mmbiz.qlogo.cn/mmbiz/qfBeGNVpnqth5fuvibEhDEKRFoPOKWwZeClxLHTiatxrhNItckyKOsqBLIG3eRIibq63UNo3DPReJ47FAYQgU1XAg/0?wx_fmt=png]]></PicUrl>";
                                //    strResponse += "<Url><![CDATA[http://mp.weixin.qq.com/s?__biz=MzAwMzAwMjAzNQ==&mid=211892611&idx=1&sn=bff89bf3934cd385ee53e2db8cc6995e#rd]]></Url>";
                                //    strResponse += "</item>";
                                //    strResponse += "</Articles>";
                                //    strResponse += "</xml>";
                                //}
                                //else
                                //{
                                //    // 显示效果
                                //    strResponse += "<xml>";
                                //    strResponse += "<ToUserName><![CDATA[" + FromUserName + "]]></ToUserName>";
                                //    strResponse += "<FromUserName><![CDATA[" + ToUserName + "]]></FromUserName>";
                                //    strResponse += "<CreateTime>" + DateTime.Now.Ticks.ToString() + "</CreateTime>";
                                //    strResponse += "<MsgType><![CDATA[text]]></MsgType>";
                                //    //strResponse += "<Content><![CDATA[" + strResult + "]]></Content>";
                                //    strResponse += "<Content><![CDATA[\ue418感谢您关注“西安交通事故快处快赔中心永久服务站”官方微信！\n事故处理,维修保养,钣喷快修,保险理赔,我们更专业.\n\ue056“陕西永久”竭诚为您服务！参与最新99元喷漆活动，请回复数字99！]]></Content>";
                                //    strResponse += "</xml>";
                                //}

                                if (Festivalactivities(content))
                                {
                                    strResponse += "<xml>";
                                    strResponse += "<ToUserName><![CDATA[" + FromUserName + "]]></ToUserName>";
                                    strResponse += "<FromUserName><![CDATA[" + ToUserName + "]]></FromUserName>";
                                    strResponse += "<CreateTime> " + DateTime.Now.Ticks.ToString() + " </CreateTime>";
                                    strResponse += "<MsgType><![CDATA[news]]></MsgType>";
                                    strResponse += "<ArticleCount>1</ArticleCount>";
                                    strResponse += "<Articles>";
                                    strResponse += "<item>";
                                    strResponse += "<Title><![CDATA[豪华车新年钣喷特惠券]]></Title>";
                                    strResponse += "<Description><![CDATA[豪华车新年钣喷特惠券]]></Description>";
                                    strResponse += "<PicUrl><![CDATA[https://mmbiz.qlogo.cn/mmbiz/qfBeGNVpnqtHJIvSWUicLIazEBxGbCK3F6D6XWHL9nYeAsmX126xZc9eowicyCgZtPh1kvQaxs1iak1KEeVFEXVsA/0?wx_fmt=png]]></PicUrl>";
                                    strResponse += "<Url><![CDATA[http://mp.weixin.qq.com/s?__biz=MzAwMzAwMjAzNQ==&mid=401815623&idx=1&sn=ec02493f3fc85e6a6bf6362e44776c42#rd]]></Url>";
                                    strResponse += "</item>";
                                    strResponse += "</Articles>";
                                    strResponse += "</xml>";
                                }
                                else
                                {
                                    // 显示效果
                                    strResponse += "<xml>";
                                    strResponse += "<ToUserName><![CDATA[" + FromUserName + "]]></ToUserName>";
                                    strResponse += "<FromUserName><![CDATA[" + ToUserName + "]]></FromUserName>";
                                    strResponse += "<CreateTime>" + DateTime.Now.Ticks.ToString() + "</CreateTime>";
                                    strResponse += "<MsgType><![CDATA[text]]></MsgType>";
                                    //strResponse += "<Content><![CDATA[" + strResult + "]]></Content>";
                                    strResponse += "<Content><![CDATA[\ue418感谢您关注“西安交通事故快处快赔中心永久服务站”官方微信！\n事故处理,维修保养,钣喷快修,保险理赔,我们更专业.\n\ue056“陕西永久”竭诚为您服务！参与最新288元新年特惠活动，请回复数字288！]]></Content>";
                                    strResponse += "</xml>";
                                }

                                //// 显示效果
                                //strResponse += "<xml>";
                                //strResponse += "<ToUserName><![CDATA[" + FromUserName + "]]></ToUserName>";
                                //strResponse += "<FromUserName><![CDATA[" + ToUserName + "]]></FromUserName>";
                                //strResponse += "<CreateTime>" + DateTime.Now.Ticks.ToString() + "</CreateTime>";
                                //strResponse += "<MsgType><![CDATA[text]]></MsgType>";
                                ////strResponse += "<Content><![CDATA[" + strResult + "]]></Content>";
                                //strResponse += "<Content><![CDATA[\ue418感谢您关注“西安交通事故快处快赔中心永久服务站”官方微信！\n事故处理,维修保养,钣喷快修,保险理赔,我们更专业.\n\ue056“陕西永久”竭诚为您服务！参与最新99元喷漆活动，请回复数字99！]]></Content>";
                                //strResponse += "</xml>";
                                break;
                        }
                        Msg += strResponse;

                        //回复图片
                        //strResponse += "<xml>";
                        //strResponse += "<ToUserName><![CDATA[" + FromUserName + "]]></ToUserName>";
                        //strResponse += "<FromUserName><![CDATA[" + ToUserName + "]]></FromUserName>";
                        //strResponse += "<CreateTime>" + DateTime.Now.Ticks.ToString() + "</CreateTime>";
                        //strResponse += "<MsgType><![CDATA[image]]></MsgType>";
                        //strResponse += "<Image>";
                        //strResponse += "<MediaId><![CDATA[" + wxhandler.MediaID + "]]></MediaId>";
                        //strResponse += "</Image>";
                        //strResponse += "</xml>";
                        //Msg += strResponse;
                    }
                    break;
                case "image":   // 图片消息
                    {
                        string PicUrl = xn.SelectSingleNode("PicUrl").InnerText;
                        string MediaId = xn.SelectSingleNode("MediaId").InnerText;
                        string MsgId = xn.SelectSingleNode("MsgId").InnerText;      // 消息id，64位整型
                        // 显示的内容
                        strResult += "FromUserName:" + FromUserName + "\n";
                        strResult += "ToUserName:" + ToUserName + "\n";
                        strResult += "CreateTime:" + CreateTime + "\n";
                        strResult += "MsgType:" + MsgType + "\n";
                        strResult += "PicUrl:" + PicUrl + "\n";
                        strResult += "MediaId:" + MediaId + "\n";
                        strResult += "MsgId:" + MsgId + "\n";
                        strResult += "CreateTimeNow:" + DateTime.Now.Ticks.ToString() + "\n";
                        Msg += strResult;
                        //// 显示效果
                        //strResponse += "<xml>";
                        //strResponse += "<ToUserName><![CDATA[" + FromUserName + "]]></ToUserName>";
                        //strResponse += "<FromUserName><![CDATA[" + ToUserName + "]]></FromUserName>";
                        //strResponse += "<CreateTime>" + DateTime.Now.Ticks.ToString() + "</CreateTime>";
                        //strResponse += "<MsgType><![CDATA[text]]></MsgType>";
                        //strResponse += "<Content><![CDATA[" + strResult + "]]></Content>";
                        //strResponse += "</xml>";
                        //Msg += strResponse;
                    }
                    break;
                case "voice":   // 语音消息
                    {
                        string MediaId = xn.SelectSingleNode("MediaId").InnerText;
                        string Format = xn.SelectSingleNode("Format").InnerText;
                        string Recognition = string.Empty;
                        if (xn.SelectSingleNode("Recognition") != null)
                        {
                            Recognition = xn.SelectSingleNode("Recognition").InnerText; // 语音识别结果，UTF8编码
                        }
                        string MsgId = xn.SelectSingleNode("MsgId").InnerText;      // 消息id，64位整型
                        // 显示的内容
                        strResult += "FromUserName:" + FromUserName + "\n";
                        strResult += "ToUserName:" + ToUserName + "\n";
                        strResult += "CreateTime:" + CreateTime + "\n";
                        strResult += "MsgType:" + MsgType + "\n";
                        strResult += "MediaId:" + MediaId + "\n";
                        strResult += "Format:" + Format + "\n";
                        strResult += "Recognition:" + Recognition + "\n";
                        strResult += "MsgId:" + MsgId + "\n";
                        Msg += strResult;
                        //// 显示效果
                        //strResponse += "<xml>";
                        //strResponse += "<ToUserName><![CDATA[" + FromUserName + "]]></ToUserName>";
                        //strResponse += "<FromUserName><![CDATA[" + ToUserName + "]]></FromUserName>";
                        //strResponse += "<CreateTime>" + DateTime.Now.Ticks.ToString() + "</CreateTime>";
                        //strResponse += "<MsgType><![CDATA[text]]></MsgType>";
                        //strResponse += "<Content><![CDATA[" + strResult + "]]></Content>";
                        //strResponse += "</xml>";
                        //Msg += strResponse;
                    }
                    break;
                case "video":   // 视频消息
                    {
                        string MediaId = xn.SelectSingleNode("MediaId").InnerText;
                        string ThumbMediaId = xn.SelectSingleNode("ThumbMediaId").InnerText;
                        string MsgId = xn.SelectSingleNode("MsgId").InnerText;      // 消息id，64位整型
                        // 显示的内容
                        strResult += "FromUserName:" + FromUserName + "\n";
                        strResult += "ToUserName:" + ToUserName + "\n";
                        strResult += "CreateTime:" + CreateTime + "\n";
                        strResult += "MsgType:" + MsgType + "\n";
                        strResult += "MediaId:" + MediaId + "\n";
                        strResult += "ThumbMediaId:" + ThumbMediaId + "\n";
                        strResult += "MsgId:" + MsgId + "\n";
                        Msg += strResult;
                        //// 显示效果
                        //strResponse += "<xml>";
                        //strResponse += "<ToUserName><![CDATA[" + FromUserName + "]]></ToUserName>";
                        //strResponse += "<FromUserName><![CDATA[" + ToUserName + "]]></FromUserName>";
                        //strResponse += "<CreateTime>" + DateTime.Now.Ticks.ToString() + "</CreateTime>";
                        //strResponse += "<MsgType><![CDATA[text]]></MsgType>";
                        //strResponse += "<Content><![CDATA[" + strResult + "]]></Content>";
                        //strResponse += "</xml>";
                        //Msg += strResponse;
                    }
                    break;
                case "shortvideo":   // 小视频消息
                    {
                        string MediaId = xn.SelectSingleNode("MediaId").InnerText;
                        string ThumbMediaId = xn.SelectSingleNode("ThumbMediaId").InnerText;
                        string MsgId = xn.SelectSingleNode("MsgId").InnerText;      // 消息id，64位整型
                        // 显示的内容
                        strResult += "FromUserName:" + FromUserName + "\n";
                        strResult += "ToUserName:" + ToUserName + "\n";
                        strResult += "CreateTime:" + CreateTime + "\n";
                        strResult += "MsgType:" + MsgType + "\n";
                        strResult += "MediaId:" + MediaId + "\n";
                        strResult += "ThumbMediaId:" + ThumbMediaId + "\n";
                        strResult += "MsgId:" + MsgId + "\n";
                        Msg += strResult;
                        //// 显示效果
                        //strResponse += "<xml>";
                        //strResponse += "<ToUserName><![CDATA[" + FromUserName + "]]></ToUserName>";
                        //strResponse += "<FromUserName><![CDATA[" + ToUserName + "]]></FromUserName>";
                        //strResponse += "<CreateTime>" + DateTime.Now.Ticks.ToString() + "</CreateTime>";
                        //strResponse += "<MsgType><![CDATA[text]]></MsgType>";
                        //strResponse += "<Content><![CDATA[" + strResult + "]]></Content>";
                        //strResponse += "</xml>";
                        //Msg += strResponse;
                    }
                    break;
                case "location":   // 地理位置消息
                    {
                        string Location_X = xn.SelectSingleNode("Location_X").InnerText;
                        string Location_Y = xn.SelectSingleNode("Location_Y ").InnerText;
                        string Scale = xn.SelectSingleNode("Scale ").InnerText;
                        string Label = xn.SelectSingleNode("Label ").InnerText;
                        string MsgId = xn.SelectSingleNode("MsgId").InnerText;      // 消息id，64位整型
                        // 显示的内容
                        strResult += "FromUserName:" + FromUserName + "\n";
                        strResult += "ToUserName:" + ToUserName + "\n";
                        strResult += "CreateTime:" + CreateTime + "\n";
                        strResult += "MsgType:" + MsgType + "\n";
                        strResult += "Location_X:" + Location_X + "\n";
                        strResult += "Location_Y:" + Location_Y + "\n";
                        strResult += "Scale:" + Scale + "\n";
                        strResult += "Label:" + Label + "\n";
                        strResult += "MsgId:" + MsgId + "\n";
                        Msg += strResult;
                        //// 显示效果
                        //strResponse += "<xml>";
                        //strResponse += "<ToUserName><![CDATA[" + FromUserName + "]]></ToUserName>";
                        //strResponse += "<FromUserName><![CDATA[" + ToUserName + "]]></FromUserName>";
                        //strResponse += "<CreateTime>" + DateTime.Now.Ticks.ToString() + "</CreateTime>";
                        //strResponse += "<MsgType><![CDATA[text]]></MsgType>";
                        //strResponse += "<Content><![CDATA[" + strResult + "]]></Content>";
                        //strResponse += "</xml>";
                        //Msg += strResponse;
                    }
                    break;
                case "link":   // 链接消息
                    {
                        string Title = xn.SelectSingleNode("Title").InnerText;
                        string Description = xn.SelectSingleNode("Description").InnerText;
                        string Url = xn.SelectSingleNode("Url").InnerText;
                        string MsgId = xn.SelectSingleNode("MsgId").InnerText;      // 消息id，64位整型
                        // 显示的内容
                        strResult += "FromUserName:" + FromUserName + "\n";
                        strResult += "ToUserName:" + ToUserName + "\n";
                        strResult += "CreateTime:" + CreateTime + "\n";
                        strResult += "MsgType:" + MsgType + "\n";
                        strResult += "Title:" + Title + "\n";
                        strResult += "Description:" + Description + "\n";
                        strResult += "Url:" + Url + "\n";
                        strResult += "MsgId:" + MsgId + "\n";
                        Msg += strResult;
                        //// 显示效果
                        //strResponse += "<xml>";
                        //strResponse += "<ToUserName><![CDATA[" + FromUserName + "]]></ToUserName>";
                        //strResponse += "<FromUserName><![CDATA[" + ToUserName + "]]></FromUserName>";
                        //strResponse += "<CreateTime>" + DateTime.Now.Ticks.ToString() + "</CreateTime>";
                        //strResponse += "<MsgType><![CDATA[text]]></MsgType>";
                        //strResponse += "<Content><![CDATA[" + strResult + "]]></Content>";
                        //strResponse += "</xml>";
                        //Msg += strResponse;
                    }
                    break;
                case "event":   // 推送事件
                    {
                        string Event = xn.SelectSingleNode("Event").InnerText;  // 事件类型
                        switch (Event)
                        {
                            case "subscribe":   // 订阅
                                {
                                    // 事件KEY值，qrscene_为前缀，后面为二维码的参数值
                                    string EventKey = string.Empty;
                                    if (xn.SelectSingleNode("EventKey") != null)
                                        EventKey = xn.SelectSingleNode("EventKey").InnerText;
                                    // 二维码的ticket，可用来换取二维码图片
                                    string Ticket = string.Empty;
                                    if (xn.SelectSingleNode("Ticket") != null)
                                        Ticket = xn.SelectSingleNode("Ticket").InnerText;
                                    // 显示的内容
                                    strResult += "FromUserName:" + FromUserName + "\n";
                                    strResult += "ToUserName:" + ToUserName + "\n";
                                    strResult += "CreateTime:" + CreateTime + "\n";
                                    strResult += "MsgType:" + MsgType + "\n";
                                    strResult += "Event:" + Event + "\n";
                                    strResult += "EventKey:" + EventKey + "\n";
                                    strResult += "Ticket:" + Ticket + "\n";
                                    // 显示效果
                                    strResponse += "<xml>";
                                    strResponse += "<ToUserName><![CDATA[" + FromUserName + "]]></ToUserName>";
                                    strResponse += "<FromUserName><![CDATA[" + ToUserName + "]]></FromUserName>";
                                    strResponse += "<CreateTime>" + DateTime.Now.Ticks.ToString() + "</CreateTime>";
                                    strResponse += "<MsgType><![CDATA[text]]></MsgType>";
                                    //strResponse += "<Content><![CDATA[" + strResult + "]]></Content>";
                                    strResponse += "<Content><![CDATA[\ue418欢迎关注“西安交通事故快处快赔中心永久服务站”官方微信！\n事故处理,维修保养,钣喷快修,保险理赔,我们更专业.\n\ue056“陕西永久”竭诚为您服务！]]></Content>";
                                    strResponse += "</xml>";
                                    Msg += strResponse;

                                }
                                break;
                            case "unsubscribe": // 取消订阅
                                {
                                    // 显示效果
                                    strResponse += "<xml><ToUserName><![CDATA[" + FromUserName + "]]></ToUserName><FromUserName><![CDATA[" + ToUserName + "]]></FromUserName><CreateTime>" + DateTime.Now.Ticks.ToString() + "</CreateTime><MsgType><![CDATA[text]]></MsgType><Content><![CDATA[感谢关注陕西永久，期待您的再次关注！\ue41f]]></Content></xml>";
                                }
                                break;
                            case "SCAN":        // 用户已关注时的事件推送
                                {
                                    // 创建二维码时的二维码scene_id
                                    string EventKey = xn.SelectSingleNode("EventKey").InnerText;
                                    // 二维码的ticket，可用来换取二维码图片
                                    string Ticket = xn.SelectSingleNode("Ticket").InnerText;
                                    // 显示的内容
                                    strResult += "FromUserName:" + FromUserName + "\n";
                                    strResult += "ToUserName:" + ToUserName + "\n";
                                    strResult += "CreateTime:" + CreateTime + "\n";
                                    strResult += "MsgType:" + MsgType + "\n";
                                    strResult += "Event:" + Event + "\n";
                                    strResult += "EventKey:" + EventKey + "\n";
                                    strResult += "Ticket:" + Ticket + "\n";
                                    Msg += strResult;
                                }
                                break;
                            case "LOCATION":    // 上报地理位置
                                {
                                    // 地理位置纬度
                                    string Latitude = xn.SelectSingleNode("Latitude").InnerText;
                                    // 地理位置经度
                                    string Longitude = xn.SelectSingleNode("Longitude").InnerText;
                                    // 地理位置精度
                                    string Precision = xn.SelectSingleNode("Precision").InnerText;
                                    // 显示的内容
                                    strResult += "FromUserName:" + FromUserName + "\n";
                                    strResult += "ToUserName:" + ToUserName + "\n";
                                    strResult += "CreateTime:" + CreateTime + "\n";
                                    strResult += "MsgType:" + MsgType + "\n";
                                    strResult += "Event:" + Event + "\n";
                                    strResult += "Latitude:" + Latitude + "\n";
                                    strResult += "Longitude:" + Longitude + "\n";
                                    strResult += "Precision:" + Precision + "\n";
                                    Msg += strResult;
                                }
                                break;
                            case "CLICK":       // 点击菜单拉取消息时的事件推送
                                {
                                    // 事件KEY值，与自定义菜单接口中KEY值对应
                                    string EventKey = xn.SelectSingleNode("EventKey").InnerText;
                                    // 显示的内容
                                    strResult += "FromUserName:" + FromUserName + "\n";
                                    strResult += "ToUserName:" + ToUserName + "\n";
                                    strResult += "CreateTime:" + CreateTime + "\n";
                                    strResult += "MsgType:" + MsgType + "\n";
                                    strResult += "Event:" + Event + "\n";
                                    strResult += "EventKey:" + EventKey + "\n";
                                    Msg += strResult;
                                    if (EventKey == "CESHI001")
                                    {
                                        strResponse += "<xml>";
                                        strResponse += "<ToUserName><![CDATA[" + FromUserName + "]]></ToUserName>";
                                        strResponse += "<FromUserName><![CDATA[" + ToUserName + "]]></FromUserName>";
                                        strResponse += "<CreateTime>" + DateTime.Now.Ticks.ToString() + "</CreateTime>";
                                        strResponse += "<MsgType><![CDATA[news]]></MsgType>";
                                        strResponse += "<ArticleCount>1</ArticleCount>";
                                        strResponse += "<Articles>";
                                        strResponse += "<item>";
                                        strResponse += "<Title><![CDATA[这是第一个]]></Title>";
                                        strResponse += "<Description><![CDATA[描述信息，第一个图文信息，点击跳转到百度，测试输入是否显示在回复信息中]]></Description>";
                                        //strResponse += "<PicUrl><![CDATA[https://mmbiz.qlogo.cn/mmbiz/H0iamQmMhnBZhqOKlNW3BUd6dShexzrvOiawQJ98HjajK65fmAqdia8n5GJsYWyiav1hXTBo9eeP1jmf3x3B6GKicsQ/0]]></PicUrl>";
                                        strResponse += "<PicUrl><![CDATA[http://qxw1152090299.my3w.com/images/41.jpg]]></PicUrl>";
                                        strResponse += "<Url><![CDATA[https://www.baidu.com/]]></Url>";
                                        strResponse += "</item>";
                                        //strResponse += "<item>";
                                        //strResponse += "<Title><![CDATA[第二个图文信息]]></Title>";
                                        //strResponse += "<Description><![CDATA[图文信息描述，第二个，点击跳转]]></Description>";
                                        ////strResponse += "<PicUrl><![CDATA[https://mmbiz.qlogo.cn/mmbiz/H0iamQmMhnBa7Mcv8GibicV7zicE8A5T5Kd2XmE3AZ1EIS8PGaIfvdLsVbiaa9tiaGPUrCL6TbXQOiaHpMBlZ2Pt8JHEQ/0]]></PicUrl>";
                                        //strResponse += "<PicUrl><![CDATA[http://qxw1152090299.my3w.com/images/123.jpg]]></PicUrl>";
                                        //strResponse += "<Url><![CDATA[http://qxw1152090299.my3w.com/]]></Url>";
                                        //strResponse += "</item>";
                                        strResponse += "</Articles>";
                                        strResponse += "</xml>";
                                        Msg += strResponse;
                                    }
                                }
                                break;
                            case "VIEW":        // 点击菜单跳转连接时的事件推送
                                {
                                    // 事件KEY值，设置的跳转URL
                                    string EventKey = xn.SelectSingleNode("EventKey").InnerText;
                                    // 显示的内容
                                    strResult += "FromUserName:" + FromUserName + "\n";
                                    strResult += "ToUserName:" + ToUserName + "\n";
                                    strResult += "CreateTime:" + CreateTime + "\n";
                                    strResult += "MsgType:" + MsgType + "\n";
                                    strResult += "Event:" + Event + "\n";
                                    strResult += "EventKey:" + EventKey + "\n";
                                    Msg += strResult;
                                }
                                break;
                            case "card_pass_check":
                                EventType = "card_pass_check";
                                // 显示效果
                                strResponse += "<xml>";
                                strResponse += "<ToUserName><![CDATA[" + FromUserName + "]]></ToUserName>";
                                strResponse += "<FromUserName><![CDATA[" + ToUserName + "]]></FromUserName>";
                                strResponse += "<CreateTime>" + DateTime.Now.Ticks.ToString() + "</CreateTime>";
                                strResponse += "<MsgType><![CDATA[text]]></MsgType>";
                                //strResponse += "<Content><![CDATA[" + strResult + "]]></Content>";
                                strResponse += "<Content><![CDATA[订购成功!!!]]></Content>";
                                strResponse += "</xml>";

                                //string tmpStr = "{";
                                //tmpStr += "\"touser\":\"" + OpenId + "\",";
                                //tmpStr += "\"template_id\":\"" + "PISesU9zLSizCllkXwUzATScnq1-56RU8YrLU2y5VYc" + "\",";
                                //tmpStr += "\"url\":\"http://222.41.193.142/UILayer/MetalPlate/index.aspx\",";
                                //tmpStr += "\"data\":{";
                                //tmpStr += "\"first\":{";
                                //tmpStr += "\"value\":\"恭喜你预约成功!\",";
                                //tmpStr += "\"color\":\"#173177\"";
                                //tmpStr += "},";
                                //tmpStr += "\"keynote1\":{";
                                //tmpStr += "\"value\":\"" + DateTime.Now.AddDays(30.0) + "\",";
                                //tmpStr += "\"color\":\"#173177\"";
                                //tmpStr += "},";
                                //tmpStr += "\"keynote2\":{";
                                //tmpStr += "\"value\":\"02986220693\",";
                                //tmpStr += "\"color\":\"#173177\"";
                                //tmpStr += "},";
                                //tmpStr += "\"keynote3\":{";
                                //tmpStr += "\"value\":\"yj86220693\",";
                                //tmpStr += "\"color\":\"#173177\"";
                                //tmpStr += "},";
                                //tmpStr += "\"remark\":{";
                                //tmpStr += "\"value\":\"欢迎再次预约！\",";
                                //tmpStr += "\"color\":\"#173177\"";
                                //tmpStr += "}";
                                //tmpStr += "}";
                                //tmpStr += "}";
                                //byte[] buf = Encoding.UTF8.GetBytes(tmpStr);
                                //string url = "https://api.weixin.qq.com/cgi-bin/message/template/send?access_token=" + accesstoken;
                                //HttpWebRequest httpReq = WebRequest.Create(url) as HttpWebRequest;
                                //httpReq.Method = "POST";
                                //using (Stream s = httpReq.GetRequestStream())
                                //{
                                //    s.Write(buf, 0, buf.Length);
                                //    s.Close();
                                //    using (HttpWebResponse myResponse = httpReq.GetResponse() as HttpWebResponse)
                                //    {
                                //        //using (StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8))
                                //        //{
                                //        //    string content = reader.ReadToEnd();
                                //        //    Response.Write(content);
                                //        //}
                                //    }
                                //}
                                break;
                            case "card_not_pass_check":
                                EventType = "card_not_pass_check";
                                // 显示效果
                                strResponse += "<xml>";
                                strResponse += "<ToUserName><![CDATA[" + FromUserName + "]]></ToUserName>";
                                strResponse += "<FromUserName><![CDATA[" + ToUserName + "]]></FromUserName>";
                                strResponse += "<CreateTime>" + DateTime.Now.Ticks.ToString() + "</CreateTime>";
                                strResponse += "<MsgType><![CDATA[text]]></MsgType>";
                                //strResponse += "<Content><![CDATA[" + strResult + "]]></Content>";
                                strResponse += "<Content><![CDATA[订购失败!!!]]></Content>";
                                strResponse += "</xml>";
                                break;
                            case "user_get_card":
                                EventType = "user_get_card";
                                string tmpStr = "{";
                                tmpStr += "\"touser\":\"" + FromUserName + "\",";
                                tmpStr += "\"template_id\":\"" + "PISesU9zLSizCllkXwUzATScnq1-56RU8YrLU2y5VYc" + "\",";
                                tmpStr += "\"url\":\"http://mp.weixin.qq.com/s?__biz=MzAwMzAwMjAzNQ==&mid=401577783&idx=1&sn=59a41acb0a1fae9653477d75e850292d#rd\",";
                                tmpStr += "\"data\":{";
                                tmpStr += "\"first\":{";
                                tmpStr += "\"value\":\"尊敬的车主，您已经成功领取卡券，我们的客服会联系您，请你保持手机畅通。\",";
                                tmpStr += "\"color\":\"#173177\"";
                                tmpStr += "},";
                                tmpStr += "\"keynote1\":{";
                                tmpStr += "\"value\":\"待确认\",";
                                tmpStr += "\"color\":\"#173177\"";
                                tmpStr += "},";
                                tmpStr += "\"keynote2\":{";
                                tmpStr += "\"value\":\"18192933995\",";
                                tmpStr += "\"color\":\"#173177\"";
                                tmpStr += "},";
                                tmpStr += "\"keynote3\":{";
                                tmpStr += "\"value\":\"yj86220693\",";
                                tmpStr += "\"color\":\"#173177\"";
                                tmpStr += "},";
                                tmpStr += "\"remark\":{";
                                tmpStr += "\"value\":\"新春钣喷特惠\",";
                                tmpStr += "\"color\":\"#173177\"";
                                tmpStr += "}";
                                tmpStr += "}";
                                tmpStr += "}";
                                byte[] buf = Encoding.UTF8.GetBytes(tmpStr);
                                string url = "https://api.weixin.qq.com/cgi-bin/message/template/send?access_token=" + accesstoken;
                                HttpWebRequest httpReq = WebRequest.Create(url) as HttpWebRequest;
                                httpReq.Method = "POST";
                                using (Stream s1 = httpReq.GetRequestStream())
                                {
                                    s1.Write(buf, 0, buf.Length);
                                    s1.Close();
                                    using (HttpWebResponse myResponse = httpReq.GetResponse() as HttpWebResponse)
                                    {
                                        //using (StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8))
                                        //{
                                        //    string content = reader.ReadToEnd();
                                        //    Response.Write(content);
                                        //}
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                default:
                    {
                        strResult += "无法识别的消息";
                        strResponse += "<xml>";
                        strResponse += "<ToUserName><![CDATA[" + FromUserName + "]]></ToUserName>";
                        strResponse += "<FromUserName><![CDATA[" + ToUserName + "]]></FromUserName>";
                        strResponse += "<CreateTime>" + DateTime.Now.Ticks.ToString() + "</CreateTime>";
                        strResponse += "<MsgType><![CDATA[text]]></MsgType>";
                        strResponse += "<Content><![CDATA[" + strResult + "]]></Content>";
                        strResponse += "</xml>";
                    }
                    break;
            }
            return strResponse;
        }
    }
}