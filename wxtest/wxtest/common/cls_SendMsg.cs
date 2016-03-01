using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wxtest.common
{
    public class cls_SendMsg
    {
        public void TextMsg(string strMsg)
        {
            string resultMsg = string.Empty;
            resultMsg += "<xml>";
            resultMsg += "<ToUserName><![CDATA[toUser]]></ToUserName>";
            resultMsg += "<FromUserName><![CDATA[fromUser]]></FromUserName>";
            resultMsg += "<CreateTime>12345678</CreateTime>";
            resultMsg += "<MsgType><![CDATA[text]]></MsgType>";
            resultMsg += "<Content><![CDATA[" + strMsg + "]]></Content>";
            resultMsg += "</xml>";
        }
    }
}