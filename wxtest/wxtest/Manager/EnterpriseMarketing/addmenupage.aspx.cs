using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wxtest.Manager.EnterpriseMarketing
{
    public partial class addmenupage : System.Web.UI.Page
    {
        protected string menu1Str { get; set; }
        protected string menu2Str { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            menu1Str = "<option>请选择上级菜单</option><option>菜单1</option><option>菜单2</option>";
            menu2Str = "<option>请选择上级菜单</option><option>菜单1</option><option>菜单2</option><option>菜单3</option><option>菜单4</option>";
            if (RequestHelper.IsPostBack(this.Request))
            {
                var t1 = this.Request.Form["menuName"];
                var t2 = this.Request.Form["menulevel"];
                var t3 = this.Request.Form["upmenu1"];
                var t4 = this.Request.Form["upmenu2"];
                var t5 = this.Request.Form["status"];
                var t6 = this.Request.Files["imgpath"];
                var t7 = this.Request.Form["ur"];
                var t8 = this.Request.Form["menusort"];
                var t9 = this.Request.Form["menutitle"];
                var t10 = this.Request.Form["editorValue"];
                var t11 = this.Request.Form["ASPSESSID"];
                var t12 = this.Request.Form["summernote"];
            }
        }
    }
}