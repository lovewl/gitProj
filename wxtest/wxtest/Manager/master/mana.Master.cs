using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wxtest.Manager.master
{
    public partial class mana : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["UserInfo"] == null)
            //{
            //    Response.Write("<p>无法获取用户信息</p>");
            //    Response.Redirect("/Manager/login.aspx");
            //}
            //else
            //{
            //    Response.Redirect("/Manager");
            //}
        }
    }
}