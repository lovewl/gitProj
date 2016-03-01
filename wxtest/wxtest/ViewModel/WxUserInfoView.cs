using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wxtest.ViewModel
{
    public class WxUserInfoView
    {
        public int Id { get; set; }
        public byte Subscribe { get; set; }
        public string OpenId { get; set; }
        public string Nickname { get; set; }
        public byte Sex { get; set; }
        public string Language { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string Headimgurl { get; set; }
        public int Subscribe_time { get; set; }
        public string Remark { get; set; }
        public byte Groupid { get; set; }
    }
}
