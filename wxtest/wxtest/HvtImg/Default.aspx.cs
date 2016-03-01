using HoverTree.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HoverTreeWeb.HvtImg
{
    public partial class Default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            { int m_totalPage,m_totalPageCount;
                PictureSelect m_pc = new PictureSelect();
                m_pc.HvtIsShow = 1;

              List<PictureInfo> m_list=  new HoverTree.BLL.HvtPicture().HvtPageQuery(m_pc,2,30,1,out m_totalPage,out m_totalPageCount);
              rptList.DataSource = m_list;
              rptList.DataBind();
            }
        }
    }
}