using HoverTree.DBTools;
using HoverTree.Framework;
using HoverTree.IDAL;
using HoverTree.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace HoverTree.SQLServerDAL
{
    public class HvtArticle : IArticle
    {
        public string Add(HoverTree.Model.ArticleInfo articleInfo)
        {
            string m_sql = "insert into hovertre" + "e_article (hvtTitle,hvtContent,hvtFileName,hvtIsShow,hvtIsHome,hvtfolder,hvteditor)values("
            + SQLTools.GetQuotes(articleInfo.HvtTitle) + "," + SQLTools.GetQuotes(articleInfo.HvtContent)
           + "," + SQLTools.GetQuotes(articleInfo.HvtFileName) + "," + Convert.ToInt32(articleInfo.HvtIsShow).ToString()
            + "," + Convert.ToInt32(articleInfo.HvtIsHome).ToString()
            + "," + SQLTools.GetQuotes(articleInfo.HvtFolder)
            +","+articleInfo.HvtEditor.ToString()
            + ")";

            int m_i = KeleyiSQLHelper.ExecuteSql(m_sql);
            if (m_i == 1)
                return string.Empty;
            else
                return "添加失败";
        }

        public string Alter(Model.ArticleInfo articleInfo)
        {
            string m_sql = "update hovertree_article set hvttitle="
            + SQLTools.GetQuotes(articleInfo.HvtTitle) + ","
            + "hvtcontent=" +SQLTools.GetQuotes(articleInfo.HvtContent)
            +","+"hvtisshow="+Convert.ToInt32(articleInfo.HvtIsShow).ToString()
            +","+"hvtishome="+Convert.ToInt32(articleInfo.HvtIsHome).ToString()
            +", hvteditor="+articleInfo.HvtEditor.ToString()
            + " where hvtisdelete=0 and hvtid=" + articleInfo.HvtId.ToString();

            return KeleyiSQLHelper.ExecuteSql(m_sql) == 1 ? "" : "修改失败";
        }

        public Model.ArticleInfo Get(int hvtid)
        {

            string m_sql = "select  * from hovertree_article where hvtisdelete=0 and hvtid=" + hvtid.ToString();
            DataRow m_drArticle=  KeleyiSQLHelper.QueryRow(m_sql);

            if (m_drArticle == null)
                return null;

            ArticleInfo m_articleInfo = new ArticleInfo();
            m_articleInfo.HvtTitle = m_drArticle["hvttitle"].ToString();
            m_articleInfo.HvtContent = m_drArticle["hvtcontent"].ToString();
            m_articleInfo.HvtFileName = m_drArticle["hvtfilename"].ToString();
            m_articleInfo.HvtId = hvtid;
            m_articleInfo.HvtTime = Convert.ToDateTime(m_drArticle["hvtTime"].ToString());
            m_articleInfo.HvtIsShow = Convert.ToBoolean(m_drArticle["hvtisshow"]);
            m_articleInfo.HvtIsHome = Convert.ToBoolean(m_drArticle["hvtishome"]);
            m_articleInfo.HvtIsDelete = Convert.ToBoolean(m_drArticle["hvtisdelete"]);
            m_articleInfo.HvtEditor = Convert.ToInt32(m_drArticle["hvteditor"]);
            m_articleInfo.HvtFolder = m_drArticle["hvtfolder"].ToString();

            return m_articleInfo;
        }

        public ArticleInfo Get(ArticleSelect articleSelect)
        {

            string m_where = " hvtisdelete=0 ";

            if (articleSelect.HvtId > 0)
                m_where = m_where + " and hvtid=" + articleSelect.HvtId.ToString();
            else if (articleSelect.HvtFileName != string.Empty)
                m_where = m_where + " and hvtfilename=" + SQLTools.GetQuotes(articleSelect.HvtFileName);
            else
                return null;

            if (articleSelect.HvtIsShow == 1)
                m_where = m_where + " and hvtisshow=1 ";
            else if (articleSelect.HvtIsShow == 0)
                m_where = m_where + " and hvtisshow=0 ";

            if (articleSelect.HvtIsHome == 1)
                m_where = m_where + " and HvtIsHome=1 ";
            else if (articleSelect.HvtIsHome == 0)
                m_where = m_where + " and HvtIsHome=0 ";
            

            string m_sql = "select  * from hovertree_article where "+m_where;
            DataRow m_drArticle = KeleyiSQLHelper.QueryRow(m_sql);

            if (m_drArticle == null)
                return null;

            ArticleInfo m_articleInfo = new ArticleInfo();
            m_articleInfo.HvtTitle = m_drArticle["hvttitle"].ToString();
            m_articleInfo.HvtContent = m_drArticle["hvtcontent"].ToString();
            m_articleInfo.HvtFileName = m_drArticle["hvtfilename"].ToString();
            m_articleInfo.HvtTime = Convert.ToDateTime(m_drArticle["hvtTime"].ToString());
            m_articleInfo.HvtIsShow = Convert.ToBoolean(m_drArticle["hvtisshow"]);
            m_articleInfo.HvtIsHome = Convert.ToBoolean(m_drArticle["hvtishome"]);
            m_articleInfo.HvtIsDelete = Convert.ToBoolean(m_drArticle["hvtisdelete"]);
            m_articleInfo.HvtEditor = Convert.ToInt32(m_drArticle["hvteditor"]);
            m_articleInfo.HvtFolder = m_drArticle["hvtfolder"].ToString();
            m_articleInfo.HvtId = Convert.ToInt32(m_drArticle["hvtid"]);

            return m_articleInfo;
        }


        public List<ArticleInfo> HvtPageQuery(int sortType, int pageSize, int pageIndex, out int totalCount, out int totalPageCount)
        {
            DataTable m_dt = KeleyiSQLHelper.HvtPageQuery("hove"+"rtree_article", "*", "hvtid", " hvtisdelete=0 "
                , "  hvtId desc  ", sortType, pageSize, pageIndex, 0, out totalCount, out totalPageCount);

            return ConvertToList(m_dt);
        }

        List<ArticleInfo> ConvertToList(DataTable articleTable)
        {
            List<ArticleInfo> m_articleList = new List<ArticleInfo>();
            if(articleTable==null)
                return null;
            int m_rows=articleTable.Rows.Count;
            if(m_rows==0)
                return m_articleList;


            for (int i = 0; i < m_rows; i++)
            {
                ArticleInfo m_articleInfo = new ArticleInfo();
                m_articleInfo.HvtTitle = articleTable.Rows[i]["hvttitle"].ToString();
                m_articleInfo.HvtContent = articleTable.Rows[i]["hvtcontent"].ToString();
                m_articleInfo.HvtFileName = articleTable.Rows[i]["hvtfilename"].ToString();
                m_articleInfo.HvtId = Convert.ToInt32(articleTable.Rows[i]["hvtid"]);
                m_articleInfo.HvtTime = Convert.ToDateTime(articleTable.Rows[i]["hvtTime"].ToString());
                m_articleInfo.HvtIsShow = Convert.ToBoolean(articleTable.Rows[i]["hvtisshow"]);
                m_articleInfo.HvtIsHome = Convert.ToBoolean(articleTable.Rows[i]["hvtishome"]);
                m_articleInfo.HvtIsDelete = Convert.ToBoolean(articleTable.Rows[i]["hvtisdelete"]);
                m_articleInfo.HvtFolder = articleTable.Rows[i]["hvtfolder"].ToString();
                m_articleList.Add(m_articleInfo);
            }


            return m_articleList;
        }


        public List<ArticleInfo> HvtPageQuery(ArticleSelect articleSelect, int sortType, int pageSize, int pageIndex, out int totalCount, out int totalPageCount)
        {
            string m_where=" hvtisdelete=0 ";
            if (articleSelect.HvtIsShow == 1)
                m_where = m_where + " and hvtisshow=1 ";
            else if (articleSelect.HvtIsShow == 0)
                m_where = m_where + " and hvtisshow=0 ";

            if (articleSelect.HvtIsHome == 1)
                m_where = m_where + " and HvtIsHome=1 ";
            else if (articleSelect.HvtIsHome == 0)
                m_where = m_where + " and HvtIsHome=0 ";

            DataTable m_dt = KeleyiSQLHelper.HvtPageQuery("hove" + "rtree_article", "*", "hvtid", m_where
                , "  hvtId desc  ", sortType, pageSize, pageIndex, 0, out totalCount, out totalPageCount);

            return ConvertToList(m_dt);
        }
    }
}