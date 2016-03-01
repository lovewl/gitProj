using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WxDev.Utility
{
    /// <summary>
    /// 时间戳与C#格式时间相互转换
    /// </summary>
    public static class TimeStampHelper
    {
        #region 时间戳转为C#格式时间 +DateTime StampToDateTime(string timeStamp)
        /// <summary>
        /// 时间戳转为C#格式时间
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <returns></returns>
        public static DateTime StampToDateTime(string timeStamp)
        {
            DateTime dateTimeStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);

            return dateTimeStart.Add(toNow);
        }
        #endregion

        #region DateTime时间格式转换为Unix时间戳格式 +int DateTimeToStamp(System.DateTime time)
        /// <summary>
        /// DateTime时间格式转换为Unix时间戳格式
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static int DateTimeToStamp(System.DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return (int)(time - startTime).TotalSeconds;
        }
        #endregion
    }
}
