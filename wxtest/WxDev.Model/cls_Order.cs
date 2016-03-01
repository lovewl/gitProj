using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WxDev.Model
{
    public class cls_Order
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 产品ID，外键
        /// </summary>
        public string ProductId { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// 车型
        /// </summary>
        public string Models { get; set; }
        /// <summary>
        /// 车牌号
        /// </summary>
        public string License { get; set; }
        /// <summary>
        /// 产品数量
        /// </summary>
        public int ProductNumbers { get; set; }
        /// <summary>
        /// 下订单日期
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public byte Status { get; set; }
    }
}
