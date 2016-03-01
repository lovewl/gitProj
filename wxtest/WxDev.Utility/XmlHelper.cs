using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml;

namespace WxDev.Utility
{
    public static class XmlHelper
    {
        public static string UpdateReadTimes(string pageName)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(HttpContext.Current.Server.MapPath("/readtimes.xml"));
            XmlElement root = xmlDoc.DocumentElement;
            try
            {
                XmlElement xe = root.SelectSingleNode("/ReadTimes/" + pageName) as XmlElement;
                int count = Convert.ToInt32(xe.GetAttribute("Count"));
                count++;
                xe.SetAttribute("Count", count.ToString());
                xmlDoc.Save(HttpContext.Current.Server.MapPath("/readtimes.xml"));
                return xe.GetAttribute("Count");
            }
            catch (Exception)
            {
                return "err";
            }
            
        }
    }
}
