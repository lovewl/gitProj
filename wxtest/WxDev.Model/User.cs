using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WxDev.Model
{
    /// <summary>
    /// 用户类
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string NickName { get; set; }
        public string WxName { get; set; }
        public string WxId { get; set; }
        public byte Status { get; set; }
    }
}
