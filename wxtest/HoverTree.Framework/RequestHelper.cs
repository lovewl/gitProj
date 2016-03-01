using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace HoverTree.Framework
{
   public class RequestHelper
    {
       public static int GetQueryInt(string strName, int defValue)
       {
           return Utils.StrToInt(HttpContext.Current.Request.QueryString[strName], defValue);
       }
    }
}
