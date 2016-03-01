using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using WxDev.Model;
using WxDev.Utility;
using wxtest.common;

namespace wxtest
{
    public partial class index : System.Web.UI.Page
    {
        private User Current_user { get; set; }
        /// <summary>
        /// 阅读次数
        /// </summary>
        protected string ReadTimes { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ReadTimes = XmlHelper.UpdateReadTimes("Page01");
            
            if (HttpContext.Current.Session != null)
            {
                if (HttpContext.Current.Session["current_user"] != null)
                {
                    Current_user = HttpContext.Current.Session["current_user"] as User;
                }
            }
            //if (RequestHelper.IsPostBack(HttpContext.Current.Request))
            //{

            //}
        }  
    }
}