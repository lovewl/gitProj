using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace HoverTree.Framework
{
   public  class Utils
    {
        public static int StrToInt(object expression, int defValue)
        {
            return TypeParse.StrToInt(expression, defValue);
        }

        public static string GetMapPath(string strPath)
        {
            return HttpContext.Current.Server.MapPath(strPath);
        }


        public static void CreateFile(string info, string path, System.Text.Encoding code)
        {
            StreamWriter sw = new StreamWriter(path, false, code);
            sw.Write(info);
            sw.Close();
        }


        public static void CreateFile(string url, string path)
        {
            Utils.CreateFile(Utils.GetHtmlByUrl(Utils.GetAbsolutePath() + url, Encoding.UTF8), Utils.GetMapPath(path), Encoding.UTF8);
        }


        public static string GetHtmlByUrl(string url, System.Text.Encoding enCode)
        {
            try
            {
                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                Stream resStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(resStream, enCode);
                string page = sr.ReadToEnd();
                resStream.Close();
                return page;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string GetAbsolutePath()
        {
            string appPath = string.Format("{0}://{1}{2}",
                HttpContext.Current.Request.Url.Scheme,
                HttpContext.Current.Request.Url.Authority,
                HttpContext.Current.Request.ApplicationPath);
            return appPath;
        }

        public static string GetHoverTreeString()
        {
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }
            return string.Format("{0:x}", i - DateTime.Now.Ticks);
        }
    }
}