using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace wxtest.common
{
    /// <summary>
    /// 自定义菜单
    /// </summary>
    public class CustomMenu
    {
        /// <summary>
        /// 创建自定义菜单
        /// </summary>
        /// <param name="context"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public static void CreateMenu(HttpContext context, string token)
        {
            // 接口调用请求
            string strUrl = "https://api.weixin.qq.com/cgi-bin/menu/create?access_token=" + token;  // 定义请求的地址
            // 转化post数据
            byte[] bytes = Encoding.UTF8.GetBytes(GetMenuStr());
            // 创建一个请求
            HttpWebRequest request = WebRequest.Create(strUrl) as HttpWebRequest;
            // 定义POST请求
            request.Method = "POST";
            using (Stream sendStream = request.GetRequestStream())
            {
                // 写入附加参数
                sendStream.Write(bytes, 0, bytes.Length);
                // 关闭流
                sendStream.Close();
                using (HttpWebResponse myResponse = request.GetResponse() as HttpWebResponse)
                {
                    using (StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8))
                    {
                        string content = reader.ReadToEnd();
                        context.Response.Write(content);
                        //return content;
                    }
                }
            }
        }
        /// <summary>
        /// 自定义菜单内容
        /// </summary>
        /// <returns></returns>
        private static string GetMenuStr()
        {
            string indexWeb = string.Empty;
            //indexWeb = "{\"button\":[{\"type\":\"view\",\"name\":\"快赔中心\",\"url\":\"http://222.41.193.142/UILayer/FastClaims.aspx\"},{\"name\":\"钣喷快修\",\"sub_button\":[{\"type\": \"view\",\"name\": \"钣喷首页\",\"url\": \"http://222.41.193.142/UILayer/MetalPlate/index.aspx\"},{\"type\": \"view\",\"name\": \"标准化流程\",\"url\": \"http://mp.weixin.qq.com/s?__biz=MzAwMzAwMjAzNQ==&mid=211734807&idx=1&sn=3076fbbe32ca0506eb650815dffbdc5c#rd/\"}]},{\"name\":\"永久汽车\",\"sub_button\":[{\"type\":\"view\",\"name\":\"永久官方\",\"url\":\"http://222.41.193.142/index.aspx\"},{\"type\":\"view\",\"name\":\"一键导航\",\"url\":\"http://map.qq.com/m/place/info/pointx=108.9307&pointy=34.29812&level=16&word=%E9%99%95%E8%A5%BF%E6%B0%B8%E4%B9%85%E6%B1%BD%E8%BD%A6%E6%9C%8D%E5%8A%A1&addr=%E4%B8%AD%E5%9B%BD%E9%99%95%E8%A5%BF%E7%9C%81%E8%A5%BF%E5%AE%89%E5%B8%82%E6%9C%AA%E5%A4%AE%E5%8C%BA%E6%98%8E%E5%85%89%E8%B7%AF158%E5%8F%B7?from=wap-map1.0&referer=weixinmp_profile\"}]}]}";
            indexWeb = "{\"button\":[{\"type\":\"view\",\"name\":\"快赔中心\",\"url\":\"http://222.41.193.142/UILayer/FastClaims.aspx\"},{\"type\":\"view\",\"name\":\"新年特惠\",\"url\":\"http://mp.weixin.qq.com/s?__biz=MzAwMzAwMjAzNQ==&mid=401577783&idx=1&sn=59a41acb0a1fae9653477d75e850292d#rd\"},{\"name\":\"永久汽车\",\"sub_button\":[{\"type\":\"view\",\"name\":\"永久官方\",\"url\":\"http://222.41.193.142/index.aspx\"},{\"type\": \"view\",\"name\": \"钣喷首页\",\"url\": \"http://222.41.193.142/UILayer/MetalPlate/index.aspx\"},{\"type\": \"view\",\"name\": \"标准化流程\",\"url\": \"http://mp.weixin.qq.com/s?__biz=MzAwMzAwMjAzNQ==&mid=211734807&idx=1&sn=3076fbbe32ca0506eb650815dffbdc5c#rd/\"}]}]}";
            return indexWeb;
        }
    }
}