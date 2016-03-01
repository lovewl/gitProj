using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxDev.Utility;

namespace wxtest.UILayer.FastClaimsPages
{
    public partial class claimsnotice : System.Web.UI.Page
    {
        /// <summary>
        /// 阅读次数
        /// </summary>
        protected string ReadTimes { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ReadTimes = XmlHelper.UpdateReadTimes("LiPeiXuZhi01");
        }
    }
}