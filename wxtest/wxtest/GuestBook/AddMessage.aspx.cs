using HoverTree.BLL;
using System;

namespace HoverTreeWeb.GuestBook
{
    public partial class AddMessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ltlTips.Text = new UserMessage().Add(txtTitle.Text, txtContent.Text, txtUser.Text);
            if (ltlTips.Text == string.Empty)
            {
                ltlTips.Text = "添加成功";
                txtContent.Text = "";
                txtTitle.Text = "";
                txtUser.Text = "";
            }

        }
    }
}