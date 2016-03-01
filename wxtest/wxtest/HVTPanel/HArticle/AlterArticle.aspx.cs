using HoverTree.Framework;
using HoverTree.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HoverTreeWeb.HVTPanel.HArticle
{
    public partial class AlterArticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int m_id;
                m_id = HoverTree.Framework.RequestHelper.GetQueryInt("hvtid", 0);

                if (m_id == 0)
                {
                    ltlTips.Text = "不存在该文章。";
                    btnSubmit.Enabled = false;
                    return;
                }

                ltlHvtId.Text = m_id.ToString();

                ArticleInfo m_articleInfo = new ArticleInfo();
                m_articleInfo = new HoverTree.BLL.HvtArticle().Get(m_id);

                txtTitle.Text = m_articleInfo.HvtTitle;
                txtContet.Text = m_articleInfo.HvtContent;
                txtFileName.Text = m_articleInfo.HvtFileName.ToString();
                cbIsShow.Checked = m_articleInfo.HvtIsShow;
                cbIsHome.Checked = m_articleInfo.HvtIsHome;
                tbFolder.Text = m_articleInfo.HvtFolder;
                ltlTime.Text = m_articleInfo.HvtTime.ToString();
                rblEditor.SelectedValue = m_articleInfo.HvtEditor.ToString();

                if(Request.UrlReferrer!=null)
                {
                    hlBack.NavigateUrl = Request.UrlReferrer.ToString();
                    hlBack.Visible = true;                
                }

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ArticleInfo m_articleInfo = new ArticleInfo();
            m_articleInfo.HvtId = Convert.ToInt32(ltlHvtId.Text);
            m_articleInfo.HvtTitle = txtTitle.Text;
            m_articleInfo.HvtContent = txtContet.Text;
            m_articleInfo.HvtIsShow = cbIsShow.Checked;
            m_articleInfo.HvtIsHome = cbIsHome.Checked;
            m_articleInfo.HvtEditor = Convert.ToInt32(rblEditor.SelectedValue);
            m_articleInfo.HvtFileName = txtFileName.Text;
            m_articleInfo.HvtFolder = tbFolder.Text;
            ltlTips.Text = new HoverTree.BLL.HvtArticle().Alter(m_articleInfo);
            if (ltlTips.Text == string.Empty)
            {
                ltlTips.Text = "修改成功";
                if(m_articleInfo.HvtIsShow)
                {
                    if (CreateHtmlFile("hvtart/artdetail.aspx?hvtid="+m_articleInfo.HvtId.ToString()
                        , "~/hvtart/"+m_articleInfo.HvtFolder+"/"+m_articleInfo.HvtFileName+".htm"))
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

            string m_fullFileName=Utils.GetMapPath(path);

            string m_folder = m_fullFileName.Remove(m_fullFileName.LastIndexOf("\\"));

            if (!Directory.Exists(m_folder))
                Directory.CreateDirectory(m_folder);

            Utils.CreateFile(m_content, Utils.GetMapPath(path), Encoding.UTF8);
            return true;
        }
    }
}