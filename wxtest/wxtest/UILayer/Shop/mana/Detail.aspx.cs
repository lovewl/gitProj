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
    public partial class Detail : System.Web.UI.Page
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        protected string ItemName { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        protected string Counts { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
        protected string UserName { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        protected string UserTel { get; set; }
        /// <summary>
        /// 车型
        /// </summary>
        protected string Models { get; set; }
        /// <summary>
        /// 车牌号
        /// </summary>
        protected string License { get; set; }
        /// <summary>
        /// 下单时间
        /// </summary>
        protected string CreateDate { get; set; }
        protected string ProductModels { get; set; }
        protected string ProductName { get; set; }
        protected string ApplicableModels { get; set; }
        protected string Unit { get; set; }
        protected string Original { get; set; }
        protected string ItemId1 { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
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
            OrderService _service = new OrderService();
            if (string.IsNullOrEmpty(Request.QueryString["itemId"]))
            {
                Response.Redirect(Request.UrlReferrer.ToString());
            }
            var Id = Request.QueryString["itemId"];
            ItemId1 = Id;
            cls_Order order = _service.QuerySingle(int.Parse(Id));
            if (order != null && order.Status == 0)
            {
                CommodityService _serviceCo = new CommodityService();
                Commodity co = _serviceCo.QuerySingle(new { ProductId = order.ProductId });
                if (co != null) ItemName = co.Name;
                Counts = order.ProductNumbers.ToString();
                UserName = order.Name;
                UserTel = order.Tel;
                Models = order.Models;
                License = order.License;
                CreateDate = order.CreateTime.ToString();
                ProductModels = co.Models;
                ProductName = co.ProductName;
                ApplicableModels = co.ApplicableModels;
                Unit = co.Unit;
                Original = co.OriginalPrice.ToString("C");
            }
            if (Request.IsPostBack())
            {
                order.Status = 1;
                _service.Update(order);
                //_service.Delete(int.Parse(Request["itemId1"]));
            }
        }
    }
}
