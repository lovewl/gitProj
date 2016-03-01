using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WxDev.Model
{
    public class Commodity
    {
        /// <summary>
        /// 主键，Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 产品Id
        /// </summary>
        public string ProductId { get; set; }
        /// <summary>
        /// 产品名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 产品图片路径
        /// </summary>
        public string ImgPath { get; set; }
        /// <summary>
        /// 产品描述
        /// </summary>
        public string Introduce { get; set; }
        /// <summary>
        /// 产品价格
        /// </summary>
        public string Price { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int ItemCount { get; set; }
        /// <summary>
        /// 库存
        /// </summary>
        public int Stock { get; set; }
        /// <summary>
        /// 商品状态
        /// </summary>
        public byte Status { get; set; }
        /// <summary>
        /// 编号型号
        /// </summary>
        public string Models { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// 适用车型
        /// </summary>
        public string ApplicableModels { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 原价
        /// </summary>
        public int OriginalPrice { get; set; }
    }
}
