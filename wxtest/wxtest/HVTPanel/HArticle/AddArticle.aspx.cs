using HoverTree.BLL;
using HoverTree.Framework;
using HoverTree.Model;
using System;
using System.IO;
using System.Text;

namespace HoverTreeWeb.HVTPanel.HArticle
{
    public partial class AddArticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            txtFileName.Text = HoverTree.Framework.Utils.GetHoverTreeString();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ArticleInfo m_articleInfo = new ArticleInfo();
            m_articleInfo.HvtTitle = txtTitle.Text;
            m_articleInfo.HvtContent = txtContet.Text;
            m_articleInfo.HvtFileName = txtFileName.Text.Trim();
            m_articleInfo.HvtIsShow = cbIsShow.Checked;
            m_articleInfo.HvtIsHome = cbIsHome.Checked;
            m_articleInfo.HvtEditor = Convert.ToInt32(rblEditor.SelectedValue);
            m_articleInfo.HvtTime = DateTime.Now;
            m_articleInfo.HvtFolder = tbFolder.Text.Trim();
            if (m_articleInfo.HvtFolder == string.Empty)
                m_articleInfo.HvtFolder = m_articleInfo.HvtTime.ToString("yyyyMM");

            ltlTips.Text = new HvtArticle().Add(m_articleInfo);
            if (ltlTips.Text == string.Empty)
            {
                ltlTips.Text = "添加成功";
                if (m_articleInfo.HvtIsShow)
                {

                    ArticleSelect m_articleSelect = new ArticleSelect();
                    m_articleSelect.HvtFileName = m_articleInfo.HvtFileName;
                    ArticleInfo m_artInfoNew = new HoverTree.BLL.HvtArticle().Get(m_articleSelect);

                    if (CreateHtmlFile("hvtart/artdetail.aspx?hvtid=" + m_artInfoNew.HvtId.ToString()
                         , "~/hvtart/" + m_artInfoNew.HvtFolder + "/" + m_artInfoNew.HvtFileName + ".htm"))
                        ltlTips.Text += "生成成功" + DateTime.Now.ToString();
                    else
                        ltlTips.Text += "生成失败" + DateTime.Now.ToString();
                }
            }
        }

        bool CreateHtmlFile(string url, string path)
        {
            string m_content = Utils.GetHtmlByUrl(Utils.GetAbsolutePath() + url, Encoding.UTF8);
            if (m_content == string.Empty)
            {
                return false;
            }

            string m_fullFileName = Utils.GetMapPath(path);

            string m_folder = m_fullFileName.Remove(m_fullFileName.LastIndexOf("\\"));

            if (!Directory.Exists(m_folder))
                Directory.CreateDirectory(m_folder);

            Utils.CreateFile(m_content, Utils.GetMapPath(path), Encoding.UTF8);
            return true;
        }

    }
}