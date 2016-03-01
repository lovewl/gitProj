using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxDev.BLL;
using WxDev.Model;

namespace wxtest.UILayer.Shop.mana
{
    public partial class manager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["redirect"] = null;
            if (Session["current_user"] == null || (Session["current_user"] as User) == null)
            {
                Session["redirect"] = Request.RawUrl;
                Response.Redirect("/account/login.aspx?HasReg=0");
            }
            User user = Session["current_user"] as User;
            if (user.Status != 100)
            {
                Response.Write("请使用管理员账号登陆");
                Response.End();
            }
            OrderService _serviceOrder = new OrderService();
            List<cls_Order> orderList = new List<cls_Order>();
            foreach (var item in _serviceOrder.QueryList(-1, 1, new { Status = 0 }, null))
            {
                orderList.Add(item);
            }
            reItems.DataSource = orderList;
            reItems.DataBind();
            CommodityService _serviceCommodity = new CommodityService();
            List<Commodity> commodityList = new List<Commodity>();
            foreach (var item in _serviceCommodity.QueryList(-1, 1, new { Status = 0 }, "Price", true))
            {
                commodityList.Add(item);
            }
            Repeater1.DataSource = commodityList;
            Repeater1.DataBind();
            if (Request.IsPostBack())
            {
                var proId = Request["txtDelete"];
                if (!string.IsNullOrEmpty(proId))
                {
                    Commodity co = _serviceCommodity.QuerySingle(new { ProductId = proId });
                    co.Status = 1;
                    _serviceCommodity.Update(co);
                    Response.Write("删除成功");
                    Response.End();
                }
                else
                {
                    Response.Write("删除失败");
                    Response.End();
                }
            }
        }
        protected string GetProductName(string productId)
        {
            CommodityService _serviceCo = new CommodityService();
            Commodity co = _serviceCo.QuerySingle(new { ProductId = productId });
            if (co == null) return "空";
            return co.Name;
        }
    }
}