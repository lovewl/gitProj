using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WxDev.Utility.Session
{
    public class OtherSessionProvider : ISessionProvider
    {
        public string SessionId
        {
            get { throw new NotImplementedException(); }
        }

        public object Get(string key)
        {
            throw new NotImplementedException();
        }

        public TResult Get<TResult>(string key) where TResult : class
        {
            throw new NotImplementedException();
        }

        public void Set(string key, object value)
        {
            throw new NotImplementedException();
        }

        public void Delete(string key)
        {
            throw new NotImplementedException();
        }
    }
}
