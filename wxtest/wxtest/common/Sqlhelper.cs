using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using wxtest.Model;

namespace wxtest.common
{
    /// <summary>
    /// 数据库操作工具
    /// </summary>
    public class Sqlhelper
    {
        //private const string connStr = "Data Source=qds154747452.my3w.com;Initial Catalog=qds154747452_db;User ID=qds154747452;Password=14789632wl;";
        private const string connStr = "server=(local);database=qds154747452_db;uid=sa;pwd=yongjiu123;";
        /// <summary>
        /// 获取记录的AccessToken以及过期时间
        /// </summary>
        /// <returns></returns>
        public static DBAccessToken GetDBAccessToken()
        {            
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from [AccessToken] where ID=1";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows) // HasRows判断reader中是否有数据
                        {
                            DBAccessToken dbToken = new DBAccessToken();
                            while (reader.Read())   // Read()方法读取下一条记录，如果没有下一条，返回false,则表示读取完成
                            {
                                dbToken.ID = Convert.ToInt32(reader["ID"]);
                                dbToken.AccessToken = Convert.ToString(reader["AccessToken"]);
                                dbToken.ExpiresIn = Convert.ToString(reader["ExpiresIn"]);
                                dbToken.CheckTime = Convert.ToDateTime(reader["CheckTime"]);
                                break;
                            }
                            conn.Close();
                            return dbToken;
                        }
                        else
                        {
                            conn.Close();
                            return null;
                        }
                    }
                }
            }
        }
        public static int UpDateDBAccessToken(DBAccessToken dbToken)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    //cmd.CommandText = "select * from [AccessToken] where ID=1";
                    cmd.CommandText = "update [AccessToken] set AccessToken=@token,ExpiresIn=@expiresIn,CheckTime=@checkTime where ID=@id";
                    cmd.Parameters.Add(new SqlParameter("@token", dbToken.AccessToken));
                    cmd.Parameters.Add(new SqlParameter("@expiresIn", dbToken.ExpiresIn));
                    cmd.Parameters.Add(new SqlParameter("@checkTime", dbToken.CheckTime));
                    cmd.Parameters.Add(new SqlParameter("@id", dbToken.ID));
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        ///// <summary>
        ///// 获取素材列表
        ///// </summary>
        //public static List<DBMaterial> GetDBMaterialList()
        //{
        //    List<DBMaterial> dbMaterrilList;
        //    using (SqlConnection conn = new SqlConnection(connStr))
        //    {
        //        conn.Open();
        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "select * from [Material]";

        //            return dbMaterrilList;
        //        }
        //    }
        //}
    }
}