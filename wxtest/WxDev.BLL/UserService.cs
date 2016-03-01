using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WxDev.DAL;
using WxDev.Model;

namespace WxDev.BLL
{
    public class UserService
    {
        /// <summary>
        /// 数据库操作对象
        /// </summary>
        private UserDAO _dao = new UserDAO();

        #region 注册结果 +RegisterResult Register(string username, string password)
        public RegisterResult Register(string username, string password)
        {
            // 校验用户名合法性
            var count = this.QueryCount(new { UserName = username });
            if (count > 0)
            {
                // 数据库已存在
                return RegisterResult.用户名已存在;
            }//select Id, UserName, Password, Name, Mobile, Address, Email, NickName, WxName, WxId, Status from [User]
            User model = new User();
            model.UserName = username;
            model.Password = password.Md5();
            model.Name = username;
            model.Mobile = string.Empty;
            model.Address = string.Empty;
            model.Email = string.Empty;
            model.NickName = username;
            model.WxName = username;
            model.WxId = string.Empty;
            model.Status = 0;
            model.Id = this.Insert(model);
            if (model.Id > 0)
            {
                return RegisterResult.注册成功;
            }
            return RegisterResult.注册失败;
        }
        #endregion

        #region 验证登陆用户 +LoginResult Login(string username, string password, out User user)
        public LoginResult Login(string username, string password, out User user)
        {
            user = null;
            // 根据用户名检索数据
            var temp = QuerySingle(new { UserName = username });

            // 判断有没有查到
            if (temp == null)
            {
                return LoginResult.用户名不存在;
            }

            // 用户存在
            if (temp.Password != password.Md5()) // 密码加密
            {
                return LoginResult.密码错误;
            }

            if (temp.Status == 255)
            {
                return LoginResult.用户已被冻结;
            }

            user = temp;
            return LoginResult.登录成功;
        }
        #endregion

        #region 验证用户 +LoginResult CookieLogin(string username, string password, out User user)
        public LoginResult CookieLogin(string username, string password, out User user)
        {
            user = null;
            // 根据用户名检索数据
            var temp = QuerySingle(new { UserName = username });

            // 判断有没有查到
            if (temp == null)
            {
                return LoginResult.用户名不存在;
            }

            // 用户存在
            if (temp.Password != password) // 密码无需加密比对  因为cookie中本来就是加密的
            {
                return LoginResult.密码错误;
            }

            if (temp.Status == 0)
            {
                return LoginResult.用户已被冻结;
            }

            user = temp;
            return LoginResult.登录成功;
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
            return _dao.Insert(model);
        }
        #endregion

        #region 删除一条记录 +int Delete(int id)
        public int Delete(int id)
        {
            return _dao.Delete(id);
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
            return _dao.Update(model);
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
            return _dao.QueryList(index, size, wheres, orderField, isDesc);
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
            return _dao.QuerySingle(wheres);
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
