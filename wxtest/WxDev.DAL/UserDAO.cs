﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using WxDev.Model;
using WxDev.Utility;

namespace WxDev.DAL
{
    public class UserDAO
    {
        #region 获取用户列表 +IEnumerable<User> GetAll()
        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetAll()
        {
            string sql = "select Id, UserName, Password, Name, Mobile, Address, Email, NickName, WxName, WxId, Status from [User]";
            using (var reader = SqlHelper.ExecuteReader(sql))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        User model = SqlHelper.MapEntity<User>(reader);

                        yield return model;
                    }
                }
            }
        }
        #endregion

        #region 向数据库中添加一条记录 +int Insert(User model)
        /// <summary>
        /// 向数据库中添加一条记录
        /// </summary>
        /// <param name="model">要添加的实体</param>
        /// <returns>插入数据的ID</returns>
        public int Insert(User model)
        {
            #region SQL语句
            const string sql = @"
INSERT INTO [dbo].[User]
           ([UserName]
           ,[Password]
           ,[Name]
           ,[Mobile]
           ,[Address]
           ,[Email]
           ,[NickName]
           ,[WxName]
           ,[WxId]
           ,[Status])
     VALUES
           (@UserName
           ,@Password
           ,@Name
           ,@Mobile
           ,@Address
           ,@Email
           ,@NickName
           ,@WxName
           ,@WxId
           ,@Status);
select @@IDENTITY";
            #endregion
            var res = SqlHelper.ExecuteScalar(sql,
                    new SqlParameter("@UserName", model.UserName),
                    new SqlParameter("@Password", model.Password),
                    new SqlParameter("@Name", model.Name),
                    new SqlParameter("@Mobile", model.Mobile),
                    new SqlParameter("@Address", model.Address),
                    new SqlParameter("@Email", model.Email),
                    new SqlParameter("@NickName", model.NickName),
                    new SqlParameter("@WxName", model.WxName),
                    new SqlParameter("@WxId", model.WxId),
                    new SqlParameter("@Status", model.Status)
                );
            return res == null ? 0 : Convert.ToInt32(res);
        }
        #endregion

        #region 删除一条记录 +int Delete(int id)
        public int Delete(int id)
        {
            const string sql = "DELETE FROM [dbo].[User] WHERE [Id] = @Id";
            return SqlHelper.ExecuteNonQuery(sql, new SqlParameter("@Id", id));
        }
        #endregion

        #region 根据主键ID更新一条记录 +int Update(User model)
        /// <summary>
        /// 根据主键ID更新一条记录
        /// </summary>
        /// <param name="model">更新后的实体</param>
        /// <returns>执行结果受影响行数</returns>
        public int Update(User model)
        {
            #region SQL语句
            const string sql = @"
UPDATE [dbo].[User]
SET 
	[UserName] = @UserName
	,[Password] = @Password
	,[Name] = @Name
	,[Mobile] = @Mobile
	,[Address] = @Address
	,[Email] = @Email
	,[NickName] = @NickName
	,[WxName] = @WxName
	,[WxId] = @WxId
	,[Status] = @Status
WHERE [Id] = @Id";
            #endregion
            return SqlHelper.ExecuteNonQuery(sql,
                    new SqlParameter("@Id", model.Id),
                    new SqlParameter("@UserName", model.UserName),
                    new SqlParameter("@Password", model.Password),
                    new SqlParameter("@Name", model.Name),
                    new SqlParameter("@Mobile", model.Mobile),
                    new SqlParameter("@Address", model.Address),
                    new SqlParameter("@Email", model.Email),
                    new SqlParameter("@NickName", model.NickName),
                    new SqlParameter("@WxName", model.WxName),
                    new SqlParameter("@WxId", model.WxId),
                    new SqlParameter("@Status", model.Status)
                );
        }
        #endregion

        #region 分页查询一个集合 +IEnumerable<User> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        /// <summary>
        /// 分页查询一个集合
        /// </summary>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <param name="wheres">条件匿名类</param>
        /// <param name="orderField">排序字段</param>
        /// <param name="isDesc">是否降序排序</param>
        /// <returns>实体集合</returns>
        public IEnumerable<User> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
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
            var sql = SqlHelper.GenerateQuerySql("User", new[] { "Id", "UserName", "Password", "Name", "Mobile", "Address", "Email", "NickName", "WxName", "WxId", "Status" }, index, size, whereBuilder.ToString(), orderField, isDesc);
            using (var reader = SqlHelper.ExecuteReader(sql, parameters.ToArray()))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        yield return SqlHelper.MapEntity<User>(reader);
                    }
                }
            }
        }
        #endregion

        #region 查询单个模型实体 +User QuerySingle(object wheres)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="wheres">条件匿名类</param>
        /// <returns>实体</returns>
        public User QuerySingle(object wheres)
        {
            var list = QueryList(1, 1, wheres, null);
            return list != null && list.Any() ? list.FirstOrDefault() : null;
        }
        #endregion

        #region 查询单个模型实体 +User QuerySingle(int id)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="id">key</param>
        /// <returns>实体</returns>
        public User QuerySingle(int id)
        {
            const string sql = "SELECT TOP 1 [Id], [UserName], [Password], [Name], [Mobile], [Address], [Email], [NickName], [WxName], [WxId], [Status] FROM [dbo].[User] WHERE [Id] = @Id";
            using (var reader = SqlHelper.ExecuteReader(sql, new SqlParameter("@Id", id)))
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    return SqlHelper.MapEntity<User>(reader);
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
            var sql = SqlHelper.GenerateQuerySql("User", new[] { "COUNT(1)" }, whereBuilder.ToString(), string.Empty);
            var res = SqlHelper.ExecuteScalar(sql, parameters.ToArray());
            return res == null ? 0 : Convert.ToInt32(res);
        }
        #endregion
    }
}
