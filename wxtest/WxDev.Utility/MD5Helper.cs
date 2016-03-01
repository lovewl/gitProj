using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace WxDev.Utility
{
    public static class MD5Helper
    {
        /// <summary>
        /// 获取文件MD5值
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <param name="capsType">MD5值大小写设置：  0：大写； 1：小写。默认大写</param>
        /// <returns>文件的MD5值</returns>
        public static string GetMD5Str(string filePath, byte capsType = 0)
        {
            using (FileStream file = new FileStream(filePath, FileMode.Open))
            {
                using (MD5 md5 = new MD5CryptoServiceProvider())
                {
                    var bytes = md5.ComputeHash(file);
                    file.Close();
                    StringBuilder sb = new StringBuilder();
                    switch (capsType)
                    {
                        case 0:
                            for (int i = 0; i < bytes.Length; i++)
                            {
                                sb.Append(bytes[i].ToString("X2"));
                            }
                            break;
                        case 1:
                            for (int i = 0; i < bytes.Length; i++)
                            {
                                sb.Append(bytes[i].ToString("x2"));
                            }
                            break;
                    }
                    md5.Dispose();

                    return sb.ToString();
                }
            }
        }
        public static string GetMD5Str(Stream stream, byte capsType = 0)
        {
            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                var bytes = md5.ComputeHash(stream);
                stream.Close();
                StringBuilder sb = new StringBuilder();
                switch (capsType)
                {
                    case 0:
                        for (int i = 0; i < bytes.Length; i++)
                        {
                            sb.Append(bytes[i].ToString("X2"));
                        }
                        break;
                    case 1:
                        for (int i = 0; i < bytes.Length; i++)
                        {
                            sb.Append(bytes[i].ToString("x2"));
                        }
                        break;
                }
                md5.Dispose();

                return sb.ToString();
            }
        }
    }
}
