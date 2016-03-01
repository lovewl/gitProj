using HoverTree.DBTools;
using HoverTree.Framework;
using HoverTree.IDAL;
using System;

namespace HoverTree.SQLServerDAL
{
    public class UserMessage : IUserMessage
    {
        public string Add(string hvtTitle, string hvtContent, string hvtUser)
        {
            string m_sql = "insert into hovertree_usermessage (hvtTitle,hvtContent,hvtUser)values("
               + SQLTools.GetQuotes(hvtTitle) + ","
               + SQLTools.GetQuotes(hvtContent) + ","
               + SQLTools.GetQuotes(hvtUser) + ")";
            int m_i = KeleyiSQLHelper.ExecuteSql(m_sql);
            if (m_i == 1)
                return string.Empty;
            else
                return "添加失败";
        }


        public System.Data.DataTable GetLast500()
        {
            string m_sql = "select top 500 * from hovertree_usermessage order by hvtid desc";
            return KeleyiSQLHelper.QueryTable(m_sql);
        }


        public System.Data.DataRow Get(int id)
        {
            string m_sql = "select  * from hovertree_usermessage where hvtid=" + id.ToString();
            return KeleyiSQLHelper.QueryRow(m_sql);
        }


        public string Handle(int id, bool isshow, string reply)
        {
            string m_sql = "update hovertree_usermessage set hvtreply="
               + SQLTools.GetQuotes(reply) + ","
               + "hvtisshow=" + Convert.ToInt32(isshow).ToString() + " where hvtid=" + id.ToString();

            return KeleyiSQLHelper.ExecuteSql(m_sql) == 1 ? "" : "修改失败";
        }


        public System.Data.DataTable GetLast100Public()
        {
            string m_sql = "select top 100 * from hovertree_usermessage where hvtisshow=1 order by hvtid desc";
            return KeleyiSQLHelper.QueryTable(m_sql);
        }

        public System.Data.DataTable HvtPageQuery(int sortType, int pageSize, int pageIndex, out int totalCount, out int totalPageCount)
        {
            return KeleyiSQLHelper.HvtPageQuery(" hovertree_usermessage ", " * ", " hvtId ", " hvtId>0 and hvtisshow=1 ", " hvtId desc ", sortType, pageSize, pageIndex, 0, out totalCount, out totalPageCount);
        }

        public System.Data.DataTable HvtPageQueryInner(int sortType, int pageSize, int pageIndex, out int totalCount, out int totalPageCount)
        {
            return KeleyiSQLHelper.HvtPageQuery(" hovertree_usermessage ", " * ", " hvtId ", " hvtId>0", " hvtId desc ", sortType, pageSize, pageIndex, 0, out totalCount, out totalPageCount);
        }
    }
}