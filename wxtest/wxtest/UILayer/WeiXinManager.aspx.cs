using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxDev.Model;
using WxDev.Utility;

namespace wxtest.UILayer
{
    public partial class WeiXinManager : System.Web.UI.Page
    {
        private User userInfo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            userInfo = Session["current_user"] as User;
            if (userInfo == null || userInfo.Status != 100)
            {
                Response.Redirect("/account/login.aspx");
            }
            if (RequestHelper.IsPostBack(Request))
            {
                //var a = 1111;
                //var b = a + 1;
                //var formData1 = Request.Form;
                //var formData2 = Request.Form[0];
                //var formData3 = Request.Form[1];
                //var formData4 = Request.Form["form1"];
                //var formData5 = Request.Form["form2"];
                //var direc = Form.AppRelativeTemplateSourceDirectory;
                //var temp1 = Form.ClientID;
                //var temp2 = Form.Controls;
                //var temp3 = Form.InnerHtml;
                //var temp4 = this.GetDataItem();
            }
        }

        protected void btn_GetAccessToken_Click(object sender, EventArgs e)
        {

        }
    }
}