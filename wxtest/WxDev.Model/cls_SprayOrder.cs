using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WxDev.Model
{
    public class cls_SprayOrder
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Guid ModelId { get; set; }
        public byte OrderType { get; set; }
        public string OrderContent { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
