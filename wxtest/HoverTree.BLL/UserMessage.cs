using HoverTree.IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HoverTree.BLL
{
    public class UserMessage
    {
        static readonly IUserMessage dal = HoverTree.DALFactory.DataAccess.CreateUserMessage();

        public string Add(string hvtTitle, string hvtContent, string hvtUser)
        {
            if (hvtTitle.Trim() == string.Empty)
                return "标题不能为空";
            if (dal == null)
                return "实例化数据库访问实例出错。";
            return dal.Add(hvtTitle,hvtContent,hvtUser);
        }

        public DataTable GetLast500()
        {
            return dal.GetLast500();
        }

        public DataRow Get(int id)
        {
            return dal.Get(id);
        }

        public string Handle(int id,bool isshow,string reply)
        {
           return dal.Handle(id, isshow, reply);
        }

        public DataTable GetLast100Public()
        {
            return dal.GetLast100Public();
        }

        public DataTable HvtPageQuery(int sortType, int pageSize, int pageIndex, out int totalCount, out int totalPageCount)
        {
            return dal.HvtPageQuery(sortType, pageSize, pageIndex, out totalCount, out totalPageCount);
        }

        public DataTable HvtPageQueryInner(int sortType, int pageSize, int pageIndex, out int totalCount, out int totalPageCount)
        {
            return dal.HvtPageQueryInner(sortType, pageSize, pageIndex, out totalCount, out totalPageCount);
        }
    }
}