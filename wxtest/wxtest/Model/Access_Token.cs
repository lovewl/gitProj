using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wxtest.Model
{
    // ACCESS_TOKEN
    public class Access_Token
    {
        // 获取到的凭证
        public string access_token { get; set; }
        // 凭证有效时间，单位：秒
        public string expires_in { get; set; }
    }
}