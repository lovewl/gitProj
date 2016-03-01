using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using wxtest.Model;

namespace wxtest.UILayer.MetalPlate
{
    public partial class semodel : System.Web.UI.Page
    {
        protected CarInfoView CarInfoView { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["brand"] != null && !string.IsNullOrWhiteSpace(Request["brand"]))
            {
                var brandid = Request["brand"];
                CarInfoView = new CarInfoView();
                CarInfoView.ModelList = CarInfoView.ModelList.Where(s => s.BrandId == brandid).OrderBy(s => s.Name);
            }
            else
            {
                Response.Redirect("sebrand.aspx");
            }
        }
    }
}