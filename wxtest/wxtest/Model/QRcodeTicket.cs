using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wxtest.Model
{
    /// <summary>
    /// 二维码实体类
    /// </summary>
    public class QRcodeTicket
    {
        /// <summary>
        /// 获取的二维码ticket
        /// </summary>
        public string Ticket { get; set; }
        /// <summary>
        /// 二维码有效时间
        /// </summary>
        public string Expire_seconds { get; set; }
        /// <summary>
        /// 二维码图片解析后的地址
        /// </summary>
        public string Url { get; set; }
    }
}