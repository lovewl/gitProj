using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WxDev.Utility.Session
{
    public static class SessionHelper
    {
        private static ISessionProvider _provider;
        private static ISessionProvider Provider
        {
            get
            {
                // c d
                if (_provider == null)
                {
                    lock ("SessionHelper_LockHelper")
                    {
                        //  
                        if (_provider == null)
                        {
                            _provider = new DefaultSessionProvider();
                        }
                    }//  a b
                } // double checkd
                return _provider;
            }
        }
        //static SessionHelper()
        //{
        //    //_provider = new DefaultSessionProvider();
        //    //switch (// 读取配置)
        //    //{
        //    //    default:
        //    //}
        //}

        public static string SessionId
        {
            get { return Provider.SessionId; }
        }

        public static object Get(string key)
        {
            return Provider.Get(key);
        }
        public static TResult Get<TResult>(string key) where TResult : class
        {
            return Provider.Get<TResult>(key);
        }

        public static void Set(string key, object value)
        {
            Provider.Set(key, value);
        }

        public static void Delete(string key)
        {
            Provider.Delete(key);
        }
    }
}
