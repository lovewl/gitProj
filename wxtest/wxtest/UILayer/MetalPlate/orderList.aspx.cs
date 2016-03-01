using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxDev.BLL;
using wxtest.BLL.CarInfo;
using wxtest.ViewModel;

namespace wxtest.UILayer.MetalPlate
{
    public partial class orderList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["current_user"] == null)
            {
                Response.Redirect("/account/login.aspx");
            }
            WxDev.Model.User currentUser = Session["current_user"] as WxDev.Model.User;
            if (currentUser == null || currentUser.Status != 100)
            {
                Response.Redirect("/account/login.aspx");
            }
            SprayOrderService service = new SprayOrderService();
            var lists = service.QueryList(-1, 1, null, null).OrderByDescending(s=>s.CreateTime).ToList();
            List<SprayOrderView> resList = new List<SprayOrderView>();
            if (lists.Count > 0)
            {
                foreach (var item in lists)
                {
                    if (item == null) continue;
                    SprayOrderView sov = new SprayOrderView();
                    sov.Id = item.Id;
                    sov.OrderContent = item.OrderContent;
                    sov.CreateTime = item.CreateTime;
                    WxDev.Model.User us = new WxDev.Model.User();
                    UserService uservice = new UserService();
                    us = uservice.QuerySingle(item.UserId);
                    sov.Name = us.Name;
                    sov.Mobile = us.Mobile;
                    ModelService moService = new ModelService();
                    var mod = moService.GetCarModelById(item.ModelId.ToString()).FirstOrDefault();
                    sov.ModelName = mod.Name;
                    var tmp1 = sov.OrderContent.Split('|');
                    int countPart = 0;
                    double price = 0.00;
                    double priceS = 0.00;
                    string contentStr = "选择的面为：";
                    for (int i = 0; i < tmp1.Length; i++)
                    {
                        switch (tmp1[i])
                        {
                            case "1740":
                                contentStr += "右后视镜 ";
                                countPart++;
                                break;
                            case "1695":
                                contentStr += "左后视镜 ";
                                countPart++;
                                break;
                            case "1705":
                                contentStr += "门把手 ";
                                countPart++;
                                break;
                            case "1685":
                                contentStr += "左前车门 ";
                                countPart++;
                                break;
                            case "1688":
                                contentStr += "左后车门 ";
                                countPart++;
                                break;
                            case "1681":
                                contentStr += "左前翼子板 ";
                                countPart++;
                                break;
                            case "1708":
                                contentStr += "左裙边 ";
                                countPart++;
                                break;
                            case "1683":
                                contentStr += "左后翼子板 ";
                                countPart++;
                                break;
                            case "1700":
                                contentStr += "右后车门 ";
                                countPart++;
                                break;
                            case "1687":
                                contentStr += "右前车门 ";
                                countPart++;
                                break;
                            case "1684":
                                contentStr += "右后翼子板 ";
                                countPart++;
                                break;
                            case "1699":
                                contentStr += "右前翼子板 ";
                                countPart++;
                                break;
                            case "1694":
                                contentStr += "右裙边 ";
                                countPart++;
                                break;
                            case "1676":
                                contentStr += "左前保险杠 ";
                                countPart++;
                                break;
                            case "1675":
                                contentStr += "右前保险杠 ";
                                countPart++;
                                break;
                            case "1677":
                                contentStr += "前保险杠全喷 ";
                                countPart++;
                                break;
                            case "1679":
                                contentStr += "左后保险杠 ";
                                countPart++;
                                break;
                            case "1678":
                                contentStr += "右后保险杠 ";
                                countPart++;
                                break;
                            case "1680":
                                contentStr += "后保险杠全喷 ";
                                countPart++;
                                break;
                            case "1707":
                                contentStr += "后车盖 ";
                                countPart++;
                                break;
                            case "1706":
                                contentStr += "前车盖 ";
                                countPart++;
                                break;
                            case "1692":
                                contentStr += "车顶 ";
                                countPart++;
                                break;
                        }
                    }
                    sov.OrderContent = contentStr;
                    //if (mod.Guidance)
                    if (mod.Guidance < 0)
                    {
                        price = -1.00;
                    }
                    else if (mod.Guidance == 0)
                    {
                        price = 0.00;
                    }
                    else if (mod.Guidance <= 15)
                    {
                        price = 260.00;
                    }
                    else if (mod.Guidance <= 30)
                    {
                        price = 350.00;
                    }
                    else if (mod.Guidance <= 45)
                    {
                        price = 400.00;
                    }
                    else if (mod.Guidance <= 70)
                    {
                        price = 500.00;
                    }
                    else
                    {
                        price = 680.00;
                    }
                    priceS = price * countPart;
                    sov.PriceSum = priceS.ToString();
                    resList.Add(sov);
                }
            }
            rptSprayOrder.DataSource = resList;
            rptSprayOrder.DataBind();
        }
    }
}