using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxDev.BLL;
using WxDev.Model;
using WxDev.Model.Enums;
using wxtest.BLL.CarInfo;

namespace wxtest.UILayer.MetalPlate
{
    public partial class plateSelf : System.Web.UI.Page
    {
        protected Dictionary<string, string> Pricelist { get; set; }
        protected string Modelid { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["current_user"] == null)
            {
                Response.Redirect("/account/login.aspx");
            }
            WxDev.Model.User userInfo = Session["current_user"] as WxDev.Model.User;
            if (Pricelist == null) Pricelist = new Dictionary<string, string>();
            else Pricelist.Clear();
            //Pricelist.Add("1740", "29");    //K2-右后视镜
            //Pricelist.Add("1695", "29");    //K1-左后视镜
            //Pricelist.Add("1705", "29");    //Q-门把手
            //Pricelist.Add("1685", "29");    //E1-左前车门
            //Pricelist.Add("1688", "29");    //F1-左后车门
            //Pricelist.Add("1681", "29");    //C1-左前翼子板
            //Pricelist.Add("1708", "29");    //J1-左裙边
            //Pricelist.Add("1683", "29");    //D1-左后翼子板
            //Pricelist.Add("1700", "29");    //F2-右后车门
            //Pricelist.Add("1687", "29");    //E2-右前车门
            //Pricelist.Add("1684", "29");    //D2-右后翼子板
            //Pricelist.Add("1699", "29");    //C2-右前翼子板
            //Pricelist.Add("1694", "29");    //J2-右裙边
            //Pricelist.Add("1676", "29");    //A2-左前保险杠
            //Pricelist.Add("1675", "29");    //A1-右前保险杠
            //Pricelist.Add("1677", "29");    //A-前保险杠全喷
            //Pricelist.Add("1679", "29");    //B2-左后保险杠
            //Pricelist.Add("1678", "29");    //B1-右后保险杠
            //Pricelist.Add("1680", "29");    //B-后保险杠全喷
            //Pricelist.Add("1707", "29");    //H-后车盖
            //Pricelist.Add("1706", "29");    //G-前车盖
            //Pricelist.Add("1692", "29");    //I-车顶

            if (Request["modeli"] != null && !string.IsNullOrWhiteSpace(Request["modeli"]))
            {
                Modelid = Request["modeli"];
                ModelService service = new ModelService();
                var models = service.GetCarModelById(Modelid).FirstOrDefault();
                var price = 0.00;
                if (models != null)
                {
                    if (models.Guidance < 0)
                    {
                        price = -1.00;
                    }
                    else if (models.Guidance == 0)
                    {
                        price = 0.00;
                    }
                    else if (models.Guidance <= 15)
                    {
                        price = 260.00;
                    }
                    else if (models.Guidance <= 30)
                    {
                        price = 350.00;
                    }
                    else if (models.Guidance <= 45)
                    {
                        price = 400.00;
                    }
                    else if (models.Guidance <= 70)
                    {
                        price = 500.00;
                    }
                    else
                    {
                        price = 680.00;
                    }
                }
                else
                {
                    price = 0.00;
                }
                Pricelist.Add("1740", price.ToString());    //K2-右后视镜
                Pricelist.Add("1695", price.ToString());    //K1-左后视镜
                Pricelist.Add("1705", price.ToString());    //Q-门把手
                Pricelist.Add("1685", price.ToString());    //E1-左前车门
                Pricelist.Add("1688", price.ToString());    //F1-左后车门
                Pricelist.Add("1681", price.ToString());    //C1-左前翼子板
                Pricelist.Add("1708", price.ToString());    //J1-左裙边
                Pricelist.Add("1683", price.ToString());    //D1-左后翼子板
                Pricelist.Add("1700", price.ToString());    //F2-右后车门
                Pricelist.Add("1687", price.ToString());    //E2-右前车门
                Pricelist.Add("1684", price.ToString());    //D2-右后翼子板
                Pricelist.Add("1699", price.ToString());    //C2-右前翼子板
                Pricelist.Add("1694", price.ToString());    //J2-右裙边
                Pricelist.Add("1676", price.ToString());    //A2-左前保险杠
                Pricelist.Add("1675", price.ToString());    //A1-右前保险杠
                Pricelist.Add("1677", price.ToString());    //A-前保险杠全喷
                Pricelist.Add("1679", price.ToString());    //B2-左后保险杠
                Pricelist.Add("1678", price.ToString());    //B1-右后保险杠
                Pricelist.Add("1680", price.ToString());    //B-后保险杠全喷
                Pricelist.Add("1707", price.ToString());    //H-后车盖
                Pricelist.Add("1706", price.ToString());    //G-前车盖
                Pricelist.Add("1692", price.ToString());    //I-车顶
                if (Request.IsPostBack())
                {
                    string resultStr = userInfo.Id.ToString();
                    bool canSave = false;
                    foreach(var item in Request.Form)
                    {
                        if (Request[item.ToString()] == "1")
                        {
                            if (!canSave) canSave = true;
                            resultStr += "|" + item.ToString();
                        }
                    }
                    if (canSave)
                    {
                        SprayOrderService soService = new SprayOrderService();
                        cls_SprayOrder mo = new cls_SprayOrder();
                        mo.UserId = userInfo.Id;
                        mo.OrderType = (byte)OrderType.Spray;
                        mo.OrderContent = resultStr;
                        mo.ModelId = Guid.Parse(Modelid);
                        //mo.ModelId = Modelid;
                        mo.CreateTime = DateTime.Now;
                        var res = soService.Insert(mo);
                        if (res > 0)
                            Response.Write("orderresult.aspx?res=ok");
                        else
                            Response.Write("orderresult.aspx?res=no");
                        Response.End();
                    }
                    else
                    {
                        Response.Write("orderresult.aspx?res=no");
                        Response.End();
                    }
                    //string result = "index.aspx";

                    //Response.Write("index.aspx");
                    //Response.End();
                    //Response.Write("success <button>ok</button><br /><hr />");
                    //Response.End();
                }
            }
            else
            {
                Response.Redirect("index.aspx");
            }
        }
    }
}