using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WxDev.Utility
{
    public static class Base64Helper
    {
        /// <summary>
        /// 对str字符串进行Base64编码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string EnCodeStr(string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            string result = Convert.ToBase64String(bytes);
            
            return result;
        }
        /// <summary>
        /// 对str字符串进行Base64解码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string UnCodeStr(string str)
        {
            byte[] outputb = Convert.FromBase64String(str);
            string orgStr = Encoding.UTF8.GetString(outputb);

            return orgStr;
        }
    }
}
