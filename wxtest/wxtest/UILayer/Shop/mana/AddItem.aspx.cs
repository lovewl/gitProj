using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxDev.BLL;
using WxDev.Model;

namespace wxtest.UILayer.Shop.mana
{
    public partial class AddItem : System.Web.UI.Page
    {
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
            if (Request.IsPostBack())
            {
                bool CanSave = true;
                string errorMSG = "";
                Commodity item = new Commodity();
                if (!Verification(Request["InputItemProductId"]))
                {
                    var itemProductId = Request["InputItemProductId"];
                    if (VerificationProductId(itemProductId))
                    {
                        item.ProductId = itemProductId;
                    }
                    else
                    {
                        CanSave = false;
                        errorMSG = "商品编号已存在,请重新输入<br />";
                    }
                }
                else
                {
                    CanSave = false;
                    errorMSG = "商品编号错误<br />";
                }
                if (!Verification(Request["InputItemName"]))
                {
                    var itemName = Request["InputItemName"];
                    item.Name = itemName;
                }
                else
                {
                    CanSave = false;
                    errorMSG += "商品名称错误<br />";
                }
                if (!Verification(Request["InputItemIntroduce"]))
                {
                    var itemIntroduce = Request["InputItemIntroduce"];
                    item.Introduce = itemIntroduce;
                }
                else
                {
                    CanSave = false;
                    errorMSG += "商品介绍错误<br />";
                }
                if (!Verification(InputFile.Value))
                {
                    var itemFile = InputFile.Value;
                    var fileBack = itemFile.LastIndexOf('.');
                    var fileBackStr = itemFile.Substring(fileBack);
                    InputFile.PostedFile.SaveAs(Server.MapPath("/images/web/Shop/items/temp"));
                    var imgMD5 = WxDev.Utility.MD5Helper.GetMD5Str(Server.MapPath("/images/web/Shop/items/temp"));
                    InputFile.PostedFile.SaveAs(Server.MapPath("/images/web/Shop/items/" + imgMD5 + fileBackStr));
                    using (FileStream fs = new FileStream(Server.MapPath("/images/web/Shop/items/" + imgMD5 + fileBackStr), FileMode.OpenOrCreate))
                    {
                        using (Bitmap btmap = new Bitmap(fs))
                        {
                            var thum = btmap.GetThumbnailImage(128, 128, null, IntPtr.Zero);
                            thum.Save(Server.MapPath("/images/web/Shop/items/temp"));
                            imgMD5 = WxDev.Utility.MD5Helper.GetMD5Str(Server.MapPath("/images/web/Shop/items/temp"));
                            thum.Save(Server.MapPath("/images/web/Shop/items/thum/" + imgMD5 + fileBackStr));
                            item.ImgPath = "/images/web/Shop/items/thum/" + imgMD5 + fileBackStr;
                        }
                    }
                }
                else
                {
                    CanSave = false;
                    errorMSG += "商品图片地址错误<br />";
                }
                if (!Verification(Request["InputItemPrice"]))
                {
                    var itemPrice = Request["InputItemPrice"];
                    item.Price = itemPrice;
                }
                else
                {
                    CanSave = false;
                    errorMSG += "商品价格错误<br />";
                }
                if (!Verification(Request["InputItemStock"]))
                {
                    var itemStock = Request["InputItemStock"];
                    Regex regex = new Regex(@"^(-)?\d+?$");
                    if (regex.IsMatch(itemStock))
                    {
                        item.Stock = int.Parse(itemStock);
                    }
                    else
                    {
                        CanSave = false;
                        errorMSG += "商品库存错误<br />";
                    }
                    
                }
                else
                {
                    CanSave = false;
                    errorMSG += "商品库存错误<br />";
                }
                if (!Verification(Request["InputItemModels"]))
                {
                    item.Models = Request["InputItemModels"];
                }
                else
                {
                    CanSave = false;
                    errorMSG += "商品编号型号错误<br />";
                }
                if (!Verification(Request["InputItemProductName"]))
                {
                    item.ProductName = Request["InputItemProductName"];
                }
                else
                {
                    CanSave = false;
                    errorMSG += "商品产品名称错误<br />";
                }
                if (!Verification(Request["InputItemApplicableModels"]))
                {
                    item.ApplicableModels = Request["InputItemApplicableModels"];
                }
                else
                {
                    CanSave = false;
                    errorMSG += "商品适用车型错误<br />";
                }
                if (!Verification(Request["InputItemUnit"]))
                {
                    item.Unit = Request["InputItemUnit"];
                }
                else
                {
                    CanSave = false;
                    errorMSG += "商品数量单位错误<br />";
                }
                if (!Verification(Request["InputItemOriginal"]))
                {
                    item.OriginalPrice = int.Parse(Request["InputItemOriginal"]);
                }
                else
                {
                    CanSave = false;
                    errorMSG += "商品原价错误<br />";
                }
                if (CanSave)
                {
                    CommodityService _service = new CommodityService();
                    _service.Insert(item);
                    Response.Write("添加成功<br />");
                    Response.Redirect("/UILayer/Shop/index.aspx");
                }
                Response.Write("添加失败<br />" + errorMSG);
                Response.End();
            }
        }
        private bool Verification(string Str)
        {
            return string.IsNullOrEmpty(Str);
        }
        private bool VerificationProductId(string Str)
        {
            CommodityService _service = new CommodityService();
            var count = _service.QueryCount(new { ProductId = Str });
            if (count != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}