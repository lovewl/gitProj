﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WxDev.Model
{
    public class WxMessage
    {
        public string FromUserName { get; set; }
        public string ToUserName { get; set; }
        public string MsgType { get; set; }
        public string EventName { get; set; }
        public string Content { get; set; }
        public string EventKey { get; set; } 
    }
}
