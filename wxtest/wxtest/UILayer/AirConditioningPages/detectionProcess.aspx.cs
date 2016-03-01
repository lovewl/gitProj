using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wxtest.UILayer.AirConditioningPages
{
    public partial class detectionProcess : System.Web.UI.Page
    {
        public static string DateStr { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            DateStr = DateTime.Now.ToString();
        }
    }
}