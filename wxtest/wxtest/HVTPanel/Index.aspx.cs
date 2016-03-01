using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using HoverTree.Framework;
using System.Text;

namespace HoverTreeWeb.HVTPanel
{
    /// <summary>
    /// http://keleyi.com/a/bjae/3d10wfax.htm
    /// </summary>
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                //ltlUsername.Text = HttpContext.Current.User.Identity.Name;
            }
            else
                FormsAuthentication.RedirectToLoginPage();
        }

        protected void lbLogout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }

        protected void btnGenerateGuestbookIndex_Click(object sender, EventArgs e)
        {
            if (CreateHtmlFile("guestbook/default.aspx", "~/guestbook/default.htm"))
                ltlTips.Text = "生成留言板首页成功" + DateTime.Now.ToString();
            else
                ltlTips.Text = "生成留言板首页失败" + DateTime.Now.ToString();
        }

        bool CreateHtmlFile(string url, string path)
        {

            string m_content = Utils.GetHtmlByUrl(Utils.GetAbsolutePath() + url, Encoding.UTF8);
            if (m_content == string.Empty)
            {
                return false;
            }

            Utils.CreateFile(m_content, Utils.GetMapPath(path), Encoding.UTF8);
            return true;
        }

        protected void btnGenerateHomePage_Click(object sender, EventArgs e)
        {
            if (CreateHtmlFile("/default.aspx", "~/default.htm"))
                ltlTips.Text = "生成首页成功" + DateTime.Now.ToString();
            else
                ltlTips.Text = "生成首页失败" + DateTime.Now.ToString();
        }
    }
}