using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxDev.BLL;
using WxDev.Model;
using WxDev.Utility;

namespace wxtest.UILayer.Shop
{
    public partial class index : System.Web.UI.Page
    {
        protected string ReadTimes { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ReadTimes = XmlHelper.UpdateReadTimes("Shop01");
            CommodityService _service = new CommodityService();
            var items = _service.QueryList1(-1, 1, new { Status = 0 }, null);
            //var ttt3 = _service.QueryList1(2, 1, null, "Price");
            reItems.DataSource = items;
            reItems.DataBind();
        }
    }
}