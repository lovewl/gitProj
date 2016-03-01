using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wxtest.UILayer.MetalPlate
{
    public partial class appointment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsPostBack())
            {
                var fileInfo1 = Request["files01"];
                var fileInfo2 = Request.Files["files01"];
                var fileInfo3 = Request["upfile"];
                var fileInfo4 = Request["m"];
                var fileInfo5 = Request["a"];
                var files = Request.Files;
            }
        }
    }
}