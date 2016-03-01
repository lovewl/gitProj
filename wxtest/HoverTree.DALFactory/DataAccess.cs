using System.Configuration;
using System.Reflection;

namespace HoverTree.DALFactory
{
    public class DataAccess
    {
        private static readonly string _path = ConfigurationManager.AppSettings["WebDALPath"];
        private static readonly string _namespace = ConfigurationManager.AppSettings["WebDALNameSpace"];

        public static HoverTree.IDAL.IUserMessage CreateUserMessage()
        {
            string className = _namespace + ".UserMessage";
            return (HoverTree.IDAL.IUserMessage)Assembly.Load(_path).CreateInstance(className);
        }

        public static HoverTree.IDAL.IArticle CreateArticle()
        {
            string className = _namespace + ".HvtArticle";
            return (HoverTree.IDAL.IArticle)Assembly.Load(_path).CreateInstance(className);
        }

        public static HoverTree.IDAL.IPicture CreatePicture()
        {
            string m_className = _namespace + ".HvtPicture";
            return (HoverTree.IDAL.IPicture)Assembly.Load(_path).CreateInstance(m_className);
        }
    }
}