using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace wxtest.SqlHelpers
{
    public class CarInfo
    {

        private static readonly string connStr = ConfigurationManager.ConnectionStrings["carInfo"].ConnectionString;
        public static int ExecuteNonQuery(string commandText, bool isText, params SqlParameter[] paramList)
        {
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = sqlConn.CreateCommand())
                {
                    if (isText)
                    {
                        cmd.CommandType = CommandType.Text;
                    }
                    else
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                    }
                    if (paramList != null && paramList.Length > 0)
                    {
                        for (int i = 0; i < paramList.Length; i++)
                        {
                            cmd.Parameters.Add(paramList[i]);
                        }
                        cmd.Parameters.Add(new SqlParameter() { ParameterName = "result", Direction = ParameterDirection.ReturnValue });
                    }
                    cmd.CommandText = commandText;
                    int res = 0;
                    try
                    {
                        sqlConn.Open();
                        //int result = cmd.ExecuteNonQuery();
                        //cmd.Parameters.Clear();
                        //return result;
                        cmd.ExecuteNonQuery();
                        if (cmd.Parameters["result"] != null)
                            res = (int)cmd.Parameters["result"].Value;
                        cmd.Parameters.Clear();
                        return res;
                    }
                    catch (SqlException)
                    {
                        sqlConn.Close();
                        return res;
                        //throw ex;
                    }
                }
            }
        }
        public static object ExecuteScalar(string commandText, bool isText, params SqlParameter[] paramList)
        {
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = sqlConn.CreateCommand())
                {
                    if (isText)
                    {
                        cmd.CommandType = CommandType.Text;
                    }
                    else
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                    }
                    if (paramList != null && paramList.Length > 0)
                    {
                        for (int i = 0; i < paramList.Length; i++)
                        {
                            cmd.Parameters.Add(paramList[i]);
                        }
                    }
                    cmd.CommandText = commandText;
                    try
                    {
                        sqlConn.Open();
                        object result = cmd.ExecuteScalar();
                        cmd.Parameters.Clear();
                        return result;
                    }
                    catch (SqlException ex)
                    {
                        sqlConn.Close();
                        throw ex;
                    }
                }
            }
        }
        public static SqlDataReader ExecuteReader(string commandText, bool isText, params SqlParameter[] paramList)
        {
            SqlConnection sqlConn = new SqlConnection(connStr);
            using (SqlCommand cmd = sqlConn.CreateCommand())
            {
                if (isText)
                {
                    cmd.CommandType = CommandType.Text;
                }
                else
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }
                if (paramList != null && paramList.Length > 0)
                {
                    for (int i = 0; i < paramList.Length; i++)
                    {
                        cmd.Parameters.Add(paramList[i]);
                    }
                }
                cmd.CommandText = commandText;
                try
                {
                    sqlConn.Open();
                    var result = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    cmd.Parameters.Clear();
                    return result;
                }
                catch (SqlException ex)
                {
                    sqlConn.Close();
                    throw ex;
                }
            }
            //using (SqlConnection sqlConn = new SqlConnection(connStr))
            //{
            //    using (SqlCommand cmd = sqlConn.CreateCommand())
            //    {
            //        if (isText)
            //        {
            //            cmd.CommandType = CommandType.Text;
            //        }
            //        else
            //        {
            //            cmd.CommandType = CommandType.StoredProcedure;
            //        }
            //        if (paramList != null && paramList.Length > 0)
            //        {
            //            for (int i = 0; i < paramList.Length; i++)
            //            {
            //                cmd.Parameters.Add(paramList[i]);
            //            }
            //        }
            //        cmd.CommandText = commandText;
            //        try
            //        {
            //            sqlConn.Open();
            //            using (var result = cmd.ExecuteReader())
            //            {
            //                cmd.Parameters.Clear();
            //                return result;
            //            }
            //        }
            //        catch (SqlException ex)
            //        {
            //            sqlConn.Close();
            //            throw ex;
            //        }
            //    }
            //}
        }
    }
}
