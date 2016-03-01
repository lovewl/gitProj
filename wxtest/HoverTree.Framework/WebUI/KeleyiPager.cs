using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoverTree.Framework.WebUI
{
    public class KeleyiPager
    {
        public static string BuildPageIndex(int pageIndex, int totalPageCount)
        {
            if (pageIndex > totalPageCount) pageIndex = totalPageCount;
            if (pageIndex < 1) pageIndex = 1;

            string m_pageIndexInfo = pageIndex.ToString() + "/" + totalPageCount.ToString();

            if (pageIndex > 2)
                m_pageIndexInfo = "<a href=\"?pi=1\">首页</a> <a href=\"?pi=" + (pageIndex - 1).ToString() + "\">上一页</a> " + m_pageIndexInfo;
            else if (pageIndex == 2)
                m_pageIndexInfo = "<a href=\"?pi=1\">首页</a> " + m_pageIndexInfo;

            if (pageIndex == totalPageCount - 1)
                m_pageIndexInfo = m_pageIndexInfo + " <a href=\"?pi=" + totalPageCount.ToString() + "\">末页</a>";
            else if (pageIndex < totalPageCount - 1)
                m_pageIndexInfo = m_pageIndexInfo + " <a href=\"?pi=" + (pageIndex + 1).ToString() + "\">下一页</a> " + "<a href=\"?pi=" + totalPageCount.ToString() + "\">末页</a> ";

            return m_pageIndexInfo;
        }
    }
}