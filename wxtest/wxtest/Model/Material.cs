using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wxtest.Model
{
    /// <summary>
    /// 素材
    /// </summary>
    public class Material
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 素材ID
        /// </summary>
        public string MediaId { get; set; }
        /// <summary>
        /// 本地服务器中的文件名
        /// </summary>
        public string FileName { get; set; }
    }
}