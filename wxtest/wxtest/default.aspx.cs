using HoverTree.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HoverTreeWeb
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int m_totalCount, m_totalPageCount;
            List<ArticleInfo> m_articleList = new List<ArticleInfo>();
            ArticleSelect m_articleSeletc = new ArticleSelect();
            m_articleSeletc.HvtIsShow = 1;
            m_articleSeletc.HvtIsHome = 1;
            m_articleList = new HoverTree.BLL.HvtArticle().HvtPageQuery(m_articleSeletc, 2, 10, 1, out m_totalCount, out m_totalPageCount);

            //rptArt.DataSource = m_articleList;
            //rptArt.DataBind();


           rptMessage.DataSource= new HoverTree.BLL.UserMessage().HvtPageQuery(2, 5, 1, out m_totalCount, out m_totalPageCount);
           rptMessage.DataBind();


           //PictureSelect m_pc = new PictureSelect();
           //m_pc.HvtIsShow = 1;
           //m_pc.HvtIsHome = 1;
           //List<PictureInfo> m_imgList = new HoverTree.BLL.HvtPicture().HvtPageQuery(m_pc, 2, 4, 1, out m_totalCount, out m_totalPageCount);
           //rptImg.DataSource = m_imgList;
           //rptImg.DataBind();
        }
    }
}