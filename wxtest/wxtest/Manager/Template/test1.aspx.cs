using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wxtest.Manager.Template
{
    public partial class test1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ArrayList values = new ArrayList();

                values.Add("Apple");
                values.Add("Orange");
                values.Add("Pear");
                values.Add("Banana");
                values.Add("Grape");
                values.Add("AAA");
                values.Add("BBB");
                values.Add("CCC");

                Repeater1.DataSource = values;
                Repeater1.DataBind();
            }
        }
    }
}