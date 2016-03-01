using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using wxtest.Model;

namespace wxtest.UILayer.MetalPlate
{
    public partial class sebrand : Page
    {
        protected CarInfoView CarInfoView { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["current_user"] == null)
            {
                Session["redirect"] = Request.Url;
                Response.Redirect("/account/login.aspx");
            }
            CarInfoView = new CarInfoView();
        }
    }
}