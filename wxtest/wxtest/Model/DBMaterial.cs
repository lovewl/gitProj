using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wxtest.Model
{
    /// <summary>
    /// 保存数据库中取出的素材信息
    /// </summary>
    public class DBMaterial
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public long ID { get; set; }
        /// <summary>
        /// 素材Id
        /// </summary>
        public string MediaId { get; set; }
        /// <summary>
        /// 本地数据库中对应的文件名
        /// </summary>
        public string FileName { get; set; }
    }
}