using HoverTree.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HoverTreeWeb.GuestBook
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rptList.DataSource = new UserMessage().GetLast100Public();
            rptList.DataBind();
        }
    }
}