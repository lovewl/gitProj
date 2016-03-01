using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WxDev.Model
{
    public class VoteForEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public int Satisfaction { get; set; }
        public string Msg { get; set; }
        public int EmployeeId { get; set; }
        public byte Status { get; set; }
    }
}
