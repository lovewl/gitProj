using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using WxDev.Model;
using WxDev.Utility;

namespace WxDev.DAL
{
    public class SprayOrderDAO
    {
        #region 获取用户列表 +IEnumerable<cls_Order> GetAll()
        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<cls_SprayOrder> GetAll()
        {
            string sql = "SELECT [Id] ,[UserId] ,[ModelId] ,[OrderType] ,[OrderContent] ,[CreateTime] FROM [dbo].[CommonOrder]";
            using (var reader = SqlHelper.ExecuteReader(sql))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cls_SprayOrder model = SqlHelper.MapEntity<cls_SprayOrder>(reader);

                        yield return model;
                    }
                }
            }
        }
        #endregion

        #region 向数据库中添加一条记录 +int Insert(cls_Order model)
        /// <summary>
        /// 向数据库中添加一条记录
        /// </summary>
        /// <param name="model">要添加的实体</param>
        /// <returns>插入数据的ID</returns>
        public int Insert(cls_SprayOrder model)
        {
            #region SQL语句
            const string sql = @"
            INSERT INTO [dbo].[CommonOrder]
           ([UserId]
           ,[ModelId]
           ,[OrderType]
           ,[OrderContent]
           ,[CreateTime])
     VALUES
           (@UserId
           ,@ModelId
           ,@OrderType
           ,@OrderContent
           ,@CreateTime) select @@IDENTITY";
            #endregion
            var res = SqlHelper.ExecuteScalar(sql,
                    new SqlParameter("@UserId", model.UserId),
                    new SqlParameter("@ModelId", model.ModelId),
                    new SqlParameter("@OrderType", model.OrderType),
                    new SqlParameter("@OrderContent", model.OrderContent),
                    new SqlParameter("@CreateTime", model.CreateTime)
                );
            return res == null ? 0 : Convert.ToInt32(res);
        }
        #endregion

        #region 删除一条记录 +int Delete(int id)
        public int Delete(int id)
        {
            const string sql = "DELETE FROM [dbo].[CommonOrder] WHERE [Id] = @Id";
            return SqlHelper.ExecuteNonQuery(sql, new SqlParameter("@Id", id));
        }
        #endregion

        #region 根据主键ID更新一条记录 +int Update(cls_Order model)
        /// <summary>
        /// 根据主键ID更新一条记录
        /// </summary>
        /// <param name="model">更新后的实体</param>
        /// <returns>执行结果受影响行数</returns>
        public int Update(cls_SprayOrder model)
        {
            #region SQL语句
            const string sql = @"
UPDATE [dbo].[CommonOrder]
   SET [UserId] = @UserId
      ,[ModelId] = @ModelId
      ,[OrderType] = @OrderType
      ,[OrderContent] = @OrderContent
 WHERE [Id] = @Id";
            #endregion
            return SqlHelper.ExecuteNonQuery(sql,
                    new SqlParameter("@Id", model.Id),
                    new SqlParameter("@UserId", model.UserId),
                    new SqlParameter("@ModelId", model.ModelId),
                    new SqlParameter("@OrderType", model.OrderType),
                    new SqlParameter("@OrderContent", model.OrderContent)
                );
        }
        #endregion

        #region 分页查询一个集合 +IEnumerable<cls_Order> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        /// <summary>
        /// 分页查询一个集合
        /// </summary>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <param name="wheres">条件匿名类</param>
        /// <param name="orderField">排序字段</param>
        /// <param name="isDesc">是否降序排序</param>
        /// <returns>实体集合</returns>
        public IEnumerable<cls_SprayOrder> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        {
            var parameters = new List<SqlParameter>();
            var whereBuilder = new System.Text.StringBuilder();
            if (wheres != null)
            {
                var props = wheres.GetType().GetProperties();
                foreach (var prop in props)
                {
                    if (prop.Name.Equals("__o", StringComparison.InvariantCultureIgnoreCase))
                    {
                        // 操作符
                        whereBuilder.AppendFormat(" {0} ", prop.GetValue(wheres, null).ToString());
                    }
                    else
                    {
                        var val = prop.GetValue(wheres, null).ToString();
                        whereBuilder.AppendFormat(" [{0}] = @{0} ", prop.Name);
                        parameters.Add(new SqlParameter("@" + prop.Name, val));
                    }
                }
            }
            var sql = SqlHelper.GenerateQuerySql("CommonOrder", new[] { "Id", "UserId", "ModelId", "OrderType", "OrderContent", "CreateTime" }, index, size, whereBuilder.ToString(), orderField, isDesc);
            using (var reader = SqlHelper.ExecuteReader(sql, parameters.ToArray()))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        yield return SqlHelper.MapEntity<cls_SprayOrder>(reader);
                    }
                }
            }
        }
        #endregion

        #region 查询单个模型实体 +cls_Order QuerySingle(object wheres)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="wheres">条件匿名类</param>
        /// <returns>实体</returns>
        public cls_SprayOrder QuerySingle(object wheres)
        {
            var list = QueryList(1, 1, wheres, null);
            return list != null && list.Any() ? list.FirstOrDefault() : null;
        }
        #endregion

        #region 查询单个模型实体 +cls_Order QuerySingle(int id)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="id">key</param>
        /// <returns>实体</returns>
        public cls_SprayOrder QuerySingle(int id)
        {
            const string sql = "SELECT TOP 1 [Id], [UserId], [ModelId], [OrderType], [OrderContent], [CreateTime] FROM [dbo].[CommonOrder] WHERE [Id] = @Id";
            using (var reader = SqlHelper.ExecuteReader(sql, new SqlParameter("@Id", id)))
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    return SqlHelper.MapEntity<cls_SprayOrder>(reader);
                }
                else
                {
                    return null;
                }
            }
        }
        #endregion

        #region 查询条数 +int QueryCount(object wheres)
        /// <summary>
        /// 查询条数
        /// </summary>
        /// <param name="wheres">查询条件</param>
        /// <returns>条数</returns>
        public int QueryCount(object wheres)
        {
            var parameters = new List<SqlParameter>();
            var whereBuilder = new System.Text.StringBuilder();
            if (wheres != null)
            {
                var props = wheres.GetType().GetProperties();
                foreach (var prop in props)
                {
                    if (prop.Name.Equals("__o", StringComparison.InvariantCultureIgnoreCase))
                    {
                        // 操作符
                        whereBuilder.AppendFormat(" {0} ", prop.GetValue(wheres, null).ToString());
                    }
                    else
                    {
                        var val = prop.GetValue(wheres, null).ToString();
                        whereBuilder.AppendFormat(" [{0}] = @{0} ", prop.Name);
                        parameters.Add(new SqlParameter("@" + prop.Name, val));
                    }
                }
            }
            var sql = SqlHelper.GenerateQuerySql("CommonOrder", new[] { "COUNT(1)" }, whereBuilder.ToString(), string.Empty);
            var res = SqlHelper.ExecuteScalar(sql, parameters.ToArray());
            return res == null ? 0 : Convert.ToInt32(res);
        }
        #endregion
    }
}
