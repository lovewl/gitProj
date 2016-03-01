using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxDev.Utility;

namespace wxtest.UILayer.FastClaimsPages
{
    public partial class claimsappointment : System.Web.UI.Page
    {
        /// <summary>
        /// 阅读次数
        /// </summary>
        protected string ReadTimes { get; set; }
        public static string DateStr { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            DateStr = DateTime.Now.ToString();
            ReadTimes = XmlHelper.UpdateReadTimes("LiPeiYuYue01");
        }
    }
}