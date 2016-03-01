using HoverTree.Framework;
using HoverTree.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web.Services;

namespace HoverTreeWeb.HVTPanel.HArticle
{
    public partial class ArticleList : System.Web.UI.Page
    {
        protected int _totalCount, _totalPageCount, _pageIndex, _pageSize;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            _pageIndex = RequestHelper.GetQueryInt("pi", 1);
            _pageSize = 30;

            List<ArticleInfo> m_articleList = new List<ArticleInfo>();
            m_articleList = new HoverTree.BLL.HvtArticle().HvtPageQuery(2, _pageSize, _pageIndex, out _totalCount, out _totalPageCount);

            rptList.DataSource = m_articleList;
            rptList.DataBind();

            ltlPages.Text = HoverTree.Framework.WebUI.KeleyiPager.BuildPageIndex(_pageIndex, _totalPageCount);

        }


        /// <summary>
        /// http://keleyi.com/a/bjac/c0me6l9l.htm
        /// </summary>
        /// <param name="hvtid"></param>
        /// <returns></returns>
        [WebMethod]
        public static string GenerateArticle(int hvtid)
        {
            if (hvtid < 1)
                return "文章ID错误";

            ArticleSelect m_articleSelect = new ArticleSelect();
            m_articleSelect.HvtId = hvtid;
            m_articleSelect.HvtIsShow = 1;
            ArticleInfo m_artInfoNew = new HoverTree.BLL.HvtArticle().Get(m_articleSelect);

            if (m_artInfoNew == null)
                return "生成失败，请确定该文章为公开的。";

            if (CreateHtmlFile("hvtart/artdetail.aspx?hvtid=" + m_articleSelect.HvtId.ToString()
                        , "~/hvtart/" + m_artInfoNew.HvtFolder + "/" + m_artInfoNew.HvtFileName + ".htm"))
                return string.Empty;
            else
                return "生成失败" + DateTime.Now.ToString();
        }

        static bool CreateHtmlFile(string url, string path)
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