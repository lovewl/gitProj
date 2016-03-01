using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.SessionState;

namespace WxDev.Utility.Session
{
    class DefaultSessionProvider : ISessionProvider
    {
        private HttpSessionState _session
        {
            get { return HttpContext.Current.Session; }
        }
        public string SessionId
        {
            get { return _session.SessionID; }
        }

        public object Get(string key)
        {
            return _session[key];
        }

        public TResult Get<TResult>(string key) where TResult : class
        {
            return Get(key) as TResult;
        }

        public void Set(string key, object value)
        {
            _session[key] = value;
        }

        public void Delete(string key)
        {
            _session.Remove(key);
        }
    }
}
