using HoverTree.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoverTree.IDAL
{
    public interface IArticle
    {
        string Add(ArticleInfo articleInfo);
        string Alter(ArticleInfo articleInfo);
        ArticleInfo Get(int hvtid);
        ArticleInfo Get(ArticleSelect articleSelect);
        List<ArticleInfo> HvtPageQuery(int sortType, int pageSize, int pageIndex, out int totalCount, out int totalPageCount);
        List<ArticleInfo> HvtPageQuery(ArticleSelect articleSelect, int sortType, int pageSize, int pageIndex, out int totalCount, out int totalPageCount);
    }
}