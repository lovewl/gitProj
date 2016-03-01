using System.Data;

namespace HoverTree.IDAL
{
    public interface IUserMessage
    {
        string Add(string hvtTitle, string hvtContent, string hvtUser);
        /// <summary>
        /// 获取最新的100条记录
        /// </summary>
        /// <returns></returns>
        DataTable GetLast500();
        DataRow Get(int id);
        string Handle(int id,bool isshow,string reply);
        DataTable GetLast100Public();
        DataTable HvtPageQuery(int sortType, int pageSize, int pageIndex,out int totalCount, out int totalPageCount);
        DataTable HvtPageQueryInner(int sortType, int pageSize, int pageIndex, out int totalCount, out int totalPageCount);

    }
}