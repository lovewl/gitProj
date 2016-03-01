using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WxDev.Utility.Session
{
    public interface ISessionProvider
    {
        string SessionId { get; }
        object Get(string key);
        TResult Get<TResult>(string key) where TResult : class;
        void Set(string key,object value);
        void Delete(string key);
    }
}
