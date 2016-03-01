using HoverTree.Framework;
using HoverTree.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HoverTreeWeb.HvtArt
{
    public partial class HvtList : System.Web.UI.Page
    {
        protected int _totalCount, _totalPageCount, _pageIndex, _pageSize;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                _pageIndex = HoverTree.Framework.RequestHelper.GetQueryInt("pi", 1);
                _pageSize = 20;
                List<ArticleInfo> m_articleList = new List<ArticleInfo>();
                ArticleSelect m_articleSeletc = new ArticleSelect();
                m_articleSeletc.HvtIsShow = 1;
                m_articleList = new HoverTree.BLL.HvtArticle().HvtPageQuery(m_articleSeletc,2,_pageSize,_pageIndex,out _totalCount ,out _totalPageCount);

                rptList.DataSource = m_articleList;
                rptList.DataBind();

                ltlPages.Text = HoverTree.Framework.WebUI.KeleyiPager.BuildPageIndex(_pageIndex, _totalPageCount);
            }
        }
    }
}