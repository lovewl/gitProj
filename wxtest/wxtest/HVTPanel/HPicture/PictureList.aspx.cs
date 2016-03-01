using HoverTree.Framework;
using HoverTree.Model;
using System;
using System.Collections.Generic;

namespace HoverTreeWeb.HVTPanel.HPicture
{
    public partial class PictureList : System.Web.UI.Page
    {
        protected int _totalCount, _totalPageCount, _pageIndex, _pageSize;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                _pageIndex = RequestHelper.GetQueryInt("pi", 1);
                _pageSize = 10;

                PictureSelect m_pictrueSelect = new PictureSelect();
                List<PictureInfo> m_pictureList = new List<PictureInfo>();
                m_pictureList = new HoverTree.BLL.HvtPicture().HvtPageQuery(m_pictrueSelect, 2, _pageSize, _pageIndex, out _totalCount, out _totalPageCount);

                rptList.DataSource = m_pictureList;
                rptList.DataBind();
            }
        }
    }
}