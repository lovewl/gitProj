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
    /// 素材管理类
    /// </summary>
    public class MaterialManagement
    {
        /// <summary>
        /// 查询素材列表
        /// </summary>
        /// <param name="context"></param>
        /// <param name="token"></param>
        public static void GetMaterialList(HttpContext context, string token)
        {
            string strUrl = "https://api.weixin.qq.com/cgi-bin/material/batchget_material?access_token=" + token;
            byte[] bytes = Encoding.UTF8.GetBytes(GetParamStr("image", 0, 1));
            HttpWebRequest request = HttpWebRequest.Create(strUrl) as HttpWebRequest;
            request.Method = "POST";
            using (Stream sendStream = request.GetRequestStream())
            {
                sendStream.Write(bytes, 0, bytes.Length);
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
        /// 查询素材需要的参数
        /// </summary>
        /// <param name="paramType"></param>
        /// <param name="paramOffSet"></param>
        /// <param name="paramCount"></param>
        /// <returns></returns>
        private static string GetParamStr(string paramType, int paramOffSet, int paramCount)
        {
            string param = string.Empty;
            param += "{\n";
            param += "\"type\":\"" + paramType + "\",\n";
            param += "\"offset\":\"" + paramOffSet + "\",\n";
            param += "\"count\":\"" + paramCount +"\"\n";
            param += "}\n";

            return param;
        }
        /// <summary>
        /// 获取素材总数
        /// </summary>
        /// <param name="context"></param>
        /// <param name="token"></param>
        public static void GetMaterialCount(HttpContext context, string token)
        {
            string strUrl = "https://api.weixin.qq.com/cgi-bin/material/get_materialcount?access_token=" + token;
            HttpWebRequest request = HttpWebRequest.Create(strUrl) as HttpWebRequest;
            request.Method = "GET";
            using (HttpWebResponse myResponse = request.GetResponse() as HttpWebResponse)
            {
                using (StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8))
                {
                    string content = reader.ReadToEnd();
                    context.Response.Write(content);
                }
            }
        }
        /// <summary>
        /// 创建临时素材
        /// </summary>
        /// <param name="context"></param>
        /// <param name="token"></param>
        public static void CreateMaterialTemp(HttpContext context, string token, string fileName)
        {
            string strUrl = "https://api.weixin.qq.com/cgi-bin/media/upload?access_token=" + token + "&type=" + "image";
            using (WebClient client = new WebClient())
            {
                string[] tmp1 = fileName.Split('.');
                switch (tmp1[tmp1.Length - 1].ToLower())
                {
                    case "tiff":
                    case "tga":
                    case "exif":
                    case "fpx":
                    case "svg":
                    case "cdr":
                    case "pcd":
                    case "dxf":
                    case "ufo":
                    case "eps":
                    case "ai":
                    case "hdr":
                    case "tif":
                    case "raw":
                    case "psd":
                    case "png":
                    case "bmp":
                    case "jpeg":
                    case "gif":
                    case "jpg":
                        fileName = "/images/" + fileName;
                        break;
                    default:
                        fileName = "/temp/" + fileName;
                        break;
                }
                byte[] b = client.UploadFile(strUrl, "POST", context.Server.MapPath(fileName));     //调用接口上传文件
                string retdata = Encoding.Default.GetString(b);//获取返回值
                if (retdata.Contains("media_id"))//判断返回值是否包含media_id，包含则说明上传成功，然后将返回的json字符串转换成json
                {
                    //return JsonConvert.DeserializeObject<UpLoadInfo>(retdata);
                    context.Response.Write(retdata);
                }
                else
                {
                    context.Response.Write("----------上传失败----------");
                }
            }
        }
        /// <summary>
        /// 上传永久素材，不包括图文素材
        /// </summary>
        /// <param name="context"></param>
        /// <param name="token"></param>
        /// <param name="fileName"></param>
        public static void CreateMedia(HttpContext context, string token, string fileName)
        {
            string strUrl = "http://api.weixin.qq.com/cgi-bin/material/add_material?access_token=" + token;
            using (WebClient client = new WebClient())
            {
                string[] tmp1 = fileName.Split('.');
                switch (tmp1[tmp1.Length - 1].ToLower())
                {
                    case "tiff":
                    case "tga":
                    case "exif":
                    case "fpx":
                    case "svg":
                    case "cdr":
                    case "pcd":
                    case "dxf":
                    case "ufo":
                    case "eps":
                    case "ai":
                    case "hdr":
                    case "tif":
                    case "raw":
                    case "psd":
                    case "png":
                    case "bmp":
                    case "jpeg":
                    case "gif":
                    case "jpg":
                        fileName = "/images/" + fileName;
                        break;
                    case "cda":
                    case "aiff":
                    case "ra":
                    case "mid":
                    case "vqf":
                    case "wav":
                    case "wma":
                    case "ogg":
                    case "au":
                    case "amr":
                    case "mp3":
                        fileName = "/voice/" + fileName;
                        break;
                    case "asf":
                    case "mov":
                    case "qt":
                    case "mpeg":
                    case "mpg":
                    case "rm":
                    case "rmvb":
                    case "wmv":
                    case "avi":
                    case "3g":
                    case "swf":
                    case "flv":
                    case "mp4":
                        fileName = "/video/" + fileName;
                        break;
                    default:
                        fileName = "/temp/" + fileName;
                        break;
                }
                byte[] b = client.UploadFile(strUrl, "POST", context.Server.MapPath(fileName));     //调用接口上传文件
                string retdata = Encoding.Default.GetString(b);     //获取返回值
                if (retdata.Contains("media_id"))//判断返回值是否包含media_id，包含则说明上传成功，然后将返回的json字符串转换成json
                {
                    //return JsonConvert.DeserializeObject<UpLoadInfo>(retdata);
                    context.Response.Write(retdata);
                }
                else
                {
                    context.Response.Write("----------上传失败----------");
                }
            }
        }
    }
}