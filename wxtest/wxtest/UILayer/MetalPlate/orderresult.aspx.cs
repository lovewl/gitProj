using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wxtest.UILayer.MetalPlate
{
    public partial class orderresult : System.Web.UI.Page
    {
        protected string Message { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            var res = Request["res"];
            if (res == "ok")
            {
                Message = "预约成功！";
            }
            else
            {
                Message = "预约失败，请核对信息后重新预约";
            }
        }
    }
}