using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WxDev.Model
{
    public class Access_Token
    {
        /// <summary>
        /// 主键，ID
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 访问令牌
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// 令牌有效时间
        /// </summary>
        public string ExpiresIn { get; set; }
        /// <summary>
        /// 令牌过期时间
        /// </summary>
        public DateTime CheckTime { get; set; }
    }
}
