using System;
using System.Web.Security;

namespace HoverTreeWeb.HVTPanel
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            ltlTips.Text = "";
            if (FormsAuthentication.Authenticate(tbUsername.Text, tbPassword.Text))
                FormsAuthentication.RedirectFromLoginPage(tbUsername.Text, false);
            else
                ltlTips.Text = "用户名或者密码错误";
        }
    }
}