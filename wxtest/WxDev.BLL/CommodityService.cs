﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WxDev.DAL;
using WxDev.Model;

namespace WxDev.BLL
{
    public class CommodityService
    {
        /// <summary>
        /// 数据库操作对象
        /// </summary>
        private CommodityDAO _dao = new CommodityDAO();

        public List<Commodity> GetAll()
        {
            return _dao.GetAll() as List<Commodity>;
        }

        #region 向数据库中添加一条记录 +int Insert(Commodity model)
        /// <summary>
        /// 向数据库中添加一条记录
        /// </summary>
        /// <param name="model">要添加的实体</param>
        /// <returns>插入数据的ID</returns>
        public int Insert(Commodity model)
        {
            return _dao.Insert(model);
        }
        #endregion

        #region 删除一条记录 +int Delete(int id)
        public int Delete(int id)
        {
            return _dao.Delete(id);
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
            return _dao.Update(model);
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
            return _dao.QueryList(index, size, wheres, orderField, isDesc);
        }
        #endregion

        public List<Commodity> QueryList2(int index, int size, object wheres, string orderField, bool isDesc = true)
        {
            List<Commodity> list = new List<Commodity>();
            foreach (var item in _dao.QueryList(index, size, wheres, orderField, isDesc))
            {
                list.Add(item);
            }
            return list;
        }

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
            return _dao.QueryList1(index, size, wheres, orderField, isDesc);
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
            return _dao.QuerySingle(wheres);
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
            return _dao.QuerySingle(id);
        }
        #endregion

        #region 查询条数 +int QueryCount(object wheres)
        /// <summary>
        /// 查询条数
        /// </summary>
        /// <param name="wheres">查询条件</param>
        /// <returns>实体</returns>
        public int QueryCount(object wheres)
        {
            return _dao.QueryCount(wheres);
        }
        #endregion
    }
}
