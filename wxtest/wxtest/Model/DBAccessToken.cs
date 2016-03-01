using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wxtest.Model
{
    /// <summary>
    /// 数据库读取的AccessToken
    /// </summary>
    public class DBAccessToken
    {
        /// <summary>
        /// 主键
        /// </summary>
        public long ID { get; set; }
        /// <summary>
        /// AccessToken的值
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// AccessToken值的有效时间
        /// </summary>
        public string ExpiresIn { get; set; }
        /// <summary>
        /// AccessToken过期时间
        /// </summary>
        public DateTime CheckTime { get; set; }
    }
}