using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wxtest.ViewModel
{
    public class SprayOrderView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string ModelName { get; set; }
        public string OrderContent { get; set; }
        public DateTime CreateTime { get; set; }
        public string PriceSum { get; set; }
    }
}
