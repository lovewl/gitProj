using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using WxDev.Model;
using WxDev.Utility;

namespace WxDev.DAL
{
    public class CommodityDAO
    {
        public List<Commodity> GetAllTest()
        {
            string sql = "SELECT [Id], [ProductId], [Name], [ImgPath], [Introduce], [Price], [ItemCount], [Stock], [Status], [Models], [ProductName], [ApplicableModels], [Unit], [OriginalPrice] FROM [dbo].[Commodity]";
            using (var reader = SqlHelper.ExecuteReader(sql))
            {
                List<Commodity> list = new List<Commodity>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Commodity model = SqlHelper.MapEntity<Commodity>(reader);
                        list.Add(model);
                        //yield return model;
                    }
                    return list;
                }
                return null;
            }
        }
        public IEnumerable<Commodity> GetAllTest1()
        {
            string sql = "SELECT [Id], [ProductId], [Name], [ImgPath], [Introduce], [Price], [ItemCount], [Stock], [Status], [Models], [ProductName], [ApplicableModels], [Unit], [OriginalPrice] FROM [dbo].[Commodity]";
            using (var reader = SqlHelper.ExecuteReader(sql))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Commodity model = SqlHelper.MapEntity<Commodity>(reader);

                        yield return model;
                    }
                }
            }
        }
        //#region 获取商品列表 +IEnumerable<Commodity> GetAll()
        ///// <summary>
        ///// 获取用户列表
        ///// </summary>
        ///// <returns></returns>
        //public IEnumerable<Commodity> GetAll()
        //{
        //    string sql = "SELECT [Id], [ProductId], [Name], [ImgPath], [Introduce], [Price], [Status] FROM [qds154747452_db].[dbo].[Commodity]";
        //    using (var reader = SqlHelper.ExecuteReader(sql))
        //    {
        //        if (reader.HasRows)
        //        {
        //            while (reader.Read())
        //            {
        //                Commodity model = SqlHelper.MapEntity<Commodity>(reader);

        //                yield return model;
        //            }
        //        }
        //    }
        //}
        //#endregion
        #region 获取商品列表 +IEnumerable<Commodity> GetAll()
        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <returns></returns>
        public List<Commodity> GetAll()
        {
            string sql = "SELECT [Id], [ProductId], [Name], [ImgPath], [Introduce], [Price], [ItemCount], [Stock], [Status], [Models], [ProductName], [ApplicableModels], [Unit], [OriginalPrice] FROM [dbo].[Commodity]";
            using (var reader = SqlHelper.ExecuteReader(sql))
            {
                List<Commodity> list = new List<Commodity>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Commodity model = SqlHelper.MapEntity<Commodity>(reader);
                        list.Add(model);
                        //yield return model;
                    }
                }
                return list;
            }
        }
        #endregion

        #region 向数据库中添加一条记录 +int Insert(Commodity model)
        /// <summary>
        /// 向数据库中添加一条记录
        /// </summary>
        /// <param name="model">要添加的实体</param>
        /// <returns>插入数据的ID</returns>
        public int Insert(Commodity model)
        {
            #region SQL语句
            const string sql = "INSERT INTO [dbo].[Commodity] ([ProductId], [Name], [ImgPath], [Introduce], [Price], [ItemCount], [Stock], [Status], [Models], [ProductName], [ApplicableModels], [Unit], [OriginalPrice]) VALUES (@ProductId, @Name, @ImgPath, @Introduce, @Price, @ItemCount, @Stock, @Status, @Models, @ProductName, @ApplicableModels, @Unit, @OriginalPrice) select @@IDENTITY";
            #endregion
            var res = SqlHelper.ExecuteScalar(sql,
                    new SqlParameter("@ProductId", model.ProductId),
                    new SqlParameter("@Name", model.Name),
                    new SqlParameter("@ImgPath", model.ImgPath),
                    new SqlParameter("@Introduce", model.Introduce),
                    new SqlParameter("@Price", model.Price),
                    new SqlParameter("@ItemCount", model.ItemCount),
                    new SqlParameter("@Stock", model.Stock),
                    new SqlParameter("@Status", model.Status),
                    new SqlParameter("@Models", model.Models),
                    new SqlParameter("@ProductName", model.ProductName),
                    new SqlParameter("@ApplicableModels", model.ApplicableModels),
                    new SqlParameter("@Unit", model.Unit),
                    new SqlParameter("@OriginalPrice", model.OriginalPrice)
                );
            return res == null ? 0 : Convert.ToInt32(res);
        }
        #endregion

        #region 删除一条记录 +int Delete(int id)
        public int Delete(int id)
        {
            const string sql = "DELETE FROM [dbo].[Commodity] WHERE [Id] = @Id";
            return SqlHelper.ExecuteNonQuery(sql, new SqlParameter("@Id", id));
        }
        #endregion

        #region 根据主键ID更新一条记录 +int Update(Commodity model)
        /// <summary>
        /// 根据主键ID更新一条记录
        /// </summary>
        /// <param name="model">更新后的实体</param>
        /// <returns>执行结果受影响行数</returns>
        public int Update(Commodity model)
        {
            #region SQL语句
            const string sql = @"UPDATE [dbo].[Commodity] SET [ProductId] = @ProductId, [Name] = @Name, [ImgPath] = @ImgPath, [Introduce] = @Introduce, [Price] = @Price, [ItemCount] = @ItemCount, [Stock] = @Stock, [Status] = @Status, [Models] = @Models, [ProductName] = @ProductName, [ApplicableModels] = @ApplicableModels, [Unit] = @Unit, [OriginalPrice] = @OriginalPrice WHERE [Id] = @Id";
            #endregion
            return SqlHelper.ExecuteNonQuery(sql,
                    new SqlParameter("@Id", model.Id),
                    new SqlParameter("@ProductId", model.ProductId),
                    new SqlParameter("@Name", model.Name),
                    new SqlParameter("@ImgPath", model.ImgPath),
                    new SqlParameter("@Introduce", model.Introduce),
                    new SqlParameter("@Price", model.Price),
                    new SqlParameter("@ItemCount", model.ItemCount),
                    new SqlParameter("@Stock", model.Stock),
                    new SqlParameter("@Status", model.Status),
                    new SqlParameter("@Models", model.Models),
                    new SqlParameter("@ProductName", model.ProductName),
                    new SqlParameter("@ApplicableModels", model.ApplicableModels),
                    new SqlParameter("@Unit", model.Unit),
                    new SqlParameter("@OriginalPrice", model.OriginalPrice)
                );
        }
        #endregion

        #region 分页查询一个集合 +IEnumerable<Commodity> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        /// <summary>
        /// 分页查询一个集合
        /// </summary>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <param name="wheres">条件匿名类</param>
        /// <param name="orderField">排序字段</param>
        /// <param name="isDesc">是否降序排序</param>
        /// <returns>实体集合</returns>
        public IEnumerable<Commodity> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
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
            var sql = SqlHelper.GenerateQuerySql("Commodity", new[] { "Id", "ProductId", "Name", "ImgPath", "Introduce", "Price", "ItemCount", "Stock", "Status", "Models", "ProductName", "ApplicableModels", "Unit", "OriginalPrice" }, index, size, whereBuilder.ToString(), orderField, isDesc);
            using (var reader = SqlHelper.ExecuteReader(sql, parameters.ToArray()))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        yield return SqlHelper.MapEntity<Commodity>(reader);
                    }
                }
            }
        }
        #endregion

        #region 分页查询一个集合 +IEnumerable<Commodity> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        /// <summary>
        /// 分页查询一个集合
        /// </summary>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <param name="wheres">条件匿名类</param>
        /// <param name="orderField">排序字段</param>
        /// <param name="isDesc">是否降序排序</param>
        /// <returns>实体集合</returns>
        public List<Commodity> QueryList1(int index, int size, object wheres, string orderField, bool isDesc = true)
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
            var sql = SqlHelper.GenerateQuerySql("Commodity", new[] { "Id", "ProductId", "Name", "ImgPath", "Introduce", "Price", "ItemCount", "Stock", "Status", "Models", "ProductName", "ApplicableModels", "Unit", "OriginalPrice" }, index, size, whereBuilder.ToString(), orderField, isDesc);
            using (var reader = SqlHelper.ExecuteReader(sql, parameters.ToArray()))
            {
                List<Commodity> list = new List<Commodity>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(SqlHelper.MapEntity<Commodity>(reader));
                        //yield return SqlHelper.MapEntity<Commodity>(reader);
                    }
                }
                return list;
            }
        }
        #endregion

        #region 查询单个模型实体 +Commodity QuerySingle(object wheres)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="wheres">条件匿名类</param>
        /// <returns>实体</returns>
        public Commodity QuerySingle(object wheres)
        {
            var list = QueryList(1, 1, wheres, null);
            return list != null && list.Any() ? list.FirstOrDefault() : null;
        }
        #endregion

        #region 查询单个模型实体 +Commodity QuerySingle(int id)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="id">key</param>
        /// <returns>实体</returns>
        public Commodity QuerySingle(int id)
        {
            const string sql = "SELECT TOP 1 [Id], [ProductId], [Name], [ImgPath], [Introduce], [Price], [ItemCount], [Stock], [Status], [Models], [ProductName], [ApplicableModels], [Unit], [OriginalPrice] FROM [dbo].[Commodity] WHERE [Id] = @Id";
            using (var reader = SqlHelper.ExecuteReader(sql, new SqlParameter("@Id", id)))
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    return SqlHelper.MapEntity<Commodity>(reader);
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
            var sql = SqlHelper.GenerateQuerySql("Commodity", new[] { "COUNT(1)" }, whereBuilder.ToString(), string.Empty);
            var res = SqlHelper.ExecuteScalar(sql, parameters.ToArray());
            return res == null ? 0 : Convert.ToInt32(res);
        }
        #endregion
    }
}
