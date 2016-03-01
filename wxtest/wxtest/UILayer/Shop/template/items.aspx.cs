using System;
using System.Text.RegularExpressions;
using System.Web;
using WxDev.BLL;
using WxDev.Model;

namespace wxtest.UILayer.Shop.template
{
    public partial class items : System.Web.UI.Page
    {
        protected Commodity commodity { get; set; }
        protected string InputName { get; set; }
        protected string InputTel { get; set; }
        protected string InputCount { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            //ItemName = WxDev.Utility.Base64Helper.UnCodeStr(Request.QueryString["itemName"]);
            CommodityService _service = new CommodityService();
            Commodity product = new Commodity();
            if (string.IsNullOrEmpty(Request.QueryString["itemName"]))
            {
                Response.Redirect("/UILayer/Shop/index.aspx");
            }
            if (string.IsNullOrEmpty(Request.QueryString["itemId"]))
            {
                Response.Redirect("/UILayer/Shop/index.aspx");
            }
            //var productName = WxDev.Utility.Base64Helper.UnCodeStr(Request.QueryString["itemName"]);
            //var productId = WxDev.Utility.Base64Helper.UnCodeStr(Request.QueryString["itemId"]);
            var productName = Request.QueryString["itemName"];
            var productId = Request.QueryString["itemId"];
            product = _service.QuerySingle(new { Id = productId });

            if (product == null) return;
            commodity = product;

            if (RequestHelper.IsPostBack(HttpContext.Current.Request))
            {
                var name = Request["UserName"];
                var tel = Request["UserTel"];
                var itemCount = Request["ItemCount"];
                var models = Request["Models"];
                var license = Request["License"];
                if (string.IsNullOrWhiteSpace(itemCount))
                {
                    InputCount = "数量错误";
                    return;
                }
                Regex regex = new Regex(@"^(-)?\d+?$");
                if (regex.IsMatch(itemCount))
                {
                    var counts = int.Parse(itemCount);
                }
                else
                {
                    InputCount = "数量错误";
                    return;
                }

                if (string.IsNullOrWhiteSpace(name))
                {
                    InputName = "请输入名称";
                    return;
                }

                if (!string.IsNullOrWhiteSpace(tel))
                {
                    if (tel.Length < 8)
                    {
                        InputTel = "电话号码格式不正确";
                        return;
                    }
                    else if (tel.Length < 10 && tel[0].ToString().Trim() != "1")
                    {
                        InputTel = "电话号码格式不正确";
                        return;
                    }
                }
                else
                {
                    InputTel = "请输入电话号码";
                    return;
                }
                OrderService _serviceOrder = new OrderService();
                cls_Order order = new cls_Order();
                order.Name = name;
                order.Tel = tel;
                order.Models = models;
                order.License = license;
                order.ProductId = product.ProductId;
                order.ProductNumbers = int.Parse(itemCount);
                order.CreateTime = DateTime.Now;
                order.Status = 0;
                product.Stock -= order.ProductNumbers;
                if (product.Stock <= 0)
                {
                    InputCount = "数量错误";
                    return;
                }
                else
                {
                    _service.Update(product);
                }
                _serviceOrder.Insert(order);

                Response.Redirect("/UILayer/Shop/template/success.aspx");
            }
        }
    }
}