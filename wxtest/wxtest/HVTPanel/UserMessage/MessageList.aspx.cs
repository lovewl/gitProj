using HoverTree.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HoverTreeWeb.HVTPanel.UserMessage
{
    public partial class MessageList : System.Web.UI.Page
    {
        protected int _totalCount, _totalPageCount, _pageIndex, _pageSize;

        protected void Page_Load(object sender, EventArgs e)
        {
            _pageIndex = HoverTree.Framework.RequestHelper.GetQueryInt("pi", 1);
            _pageSize = 20;


            rptMessageList.DataSource = new HoverTree.BLL.UserMessage().HvtPageQueryInner(2, _pageSize, _pageIndex, out _totalCount, out _totalPageCount);
            rptMessageList.DataBind();

            ltlPages.Text =HoverTree.Framework.WebUI.KeleyiPager. BuildPageIndex(_pageIndex, _totalPageCount);
        }
    }
}