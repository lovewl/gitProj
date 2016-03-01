using HoverTree.Framework;
using HoverTree.Model;
using System;

namespace HoverTreeWeb.HvtArt
{
    public partial class ArtDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                ArticleSelect m_articleSelect = new ArticleSelect();
                m_articleSelect.HvtId = RequestHelper.GetQueryInt("hvtid", 0);

                if (m_articleSelect.HvtId == 0)
                {
                    ltlTips.Text = "文章不存在。";
                    return;
                }

                m_articleSelect.HvtIsShow = 1;


                ArticleInfo m_articleInfo = new HoverTree.BLL.HvtArticle().Get(m_articleSelect);

                if (m_articleInfo == null)
                {
                    ltlTips.Text = "文章不存在。";
                    return;
                }

               // ltlContent.Text = Server.HtmlEncode(m_articleInfo.HvtContent).Replace(System.Environment.NewLine, "<br />");
                ltlContent.Text = m_articleInfo.HvtContentShow;
                ltlTime.Text = m_articleInfo.HvtTime.ToString("yyyy-MM-dd");
                ltlTitle.Text = Server.HtmlEncode(m_articleInfo.HvtTitle);

                Page.Title = m_articleInfo.HvtTitle;
            }
        }
    }
}