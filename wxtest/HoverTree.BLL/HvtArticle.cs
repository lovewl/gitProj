using HoverTree.IDAL;
using HoverTree.Model;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web;

namespace HoverTree.BLL
{
   public class HvtArticle
    {
       static readonly IArticle dal = HoverTree.DALFactory.DataAccess.CreateArticle();

       public string Add(HoverTree.Model.ArticleInfo articleInfo)
       {

           string strRegex = @"^([a-z\d]){1,18}$";
           if (!(Regex.IsMatch(articleInfo.HvtFolder, strRegex)))
               return "文件夹名不符合规范";

          return  dal.Add(articleInfo);
       }

       public string Alter(ArticleInfo articleInfo)
       {
           return dal.Alter(articleInfo);
       }

       public ArticleInfo Get(int hvtid)
       {
           ArticleInfo m_articleInfo = new ArticleInfo();

           m_articleInfo = dal.Get(hvtid);

           if (m_articleInfo.HvtEditor == 0)
               m_articleInfo.HvtContentShow = HttpUtility.HtmlEncode(m_articleInfo.HvtContent).Replace(System.Environment.NewLine, "<br />");
           else
               m_articleInfo.HvtContentShow = m_articleInfo.HvtContent;

           return m_articleInfo;
       }

       public ArticleInfo Get(ArticleSelect articleSelect)
       {
           ArticleInfo m_articleInfo = new ArticleInfo();
           m_articleInfo= dal.Get(articleSelect);

           if (m_articleInfo.HvtEditor == 0)
               m_articleInfo.HvtContentShow = HttpUtility.HtmlEncode(m_articleInfo.HvtContent).Replace(System.Environment.NewLine, "<br />");
           else
               m_articleInfo.HvtContentShow = m_articleInfo.HvtContent;

           return m_articleInfo;
       }

       public List<ArticleInfo> HvtPageQuery(int sortType, int pageSize, int pageIndex, out int totalCount, out int totalPageCount)
       {
           return dal.HvtPageQuery(sortType, pageSize, pageIndex, out totalCount, out totalPageCount);
       }

       public List<ArticleInfo> HvtPageQuery(ArticleSelect articleSelect,int sortType, int pageSize, int pageIndex, out int totalCount, out int totalPageCount)
       {
           return dal.HvtPageQuery(articleSelect,sortType, pageSize, pageIndex, out totalCount, out totalPageCount);
       }
    }
}