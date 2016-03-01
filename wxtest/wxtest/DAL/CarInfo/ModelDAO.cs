using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace wxtest.DAL.CarInfo
{
    public class ModelDAO
    {
        public int AddCarModel(string name, bool isImported, string brandId, double guidance)
        {
            var id = Guid.NewGuid();
            return SqlHelpers.CarInfo.ExecuteNonQuery("AddCarModel", false, new SqlParameter("id", id), new SqlParameter("name", name), new SqlParameter("isImported", isImported), new SqlParameter("brandId", brandId), new SqlParameter("guidance", guidance));
        }
        public int DelCarModelById(string id)
        {
            return SqlHelpers.CarInfo.ExecuteNonQuery("DelCarModelById", false, new SqlParameter("id", id));
        }
        public int UpdateCarModelById(string id, string name, bool isImported, string brandId, double guidance)
        {
            var brandid = Guid.Parse(brandId);
            return SqlHelpers.CarInfo.ExecuteNonQuery("UpdateCarModelById", false, new SqlParameter("id", id), new SqlParameter("name", name), new SqlParameter("isImported", isImported), new SqlParameter("brandId", brandid), new SqlParameter("guidance", guidance));
        }
        public IEnumerable<Model.CarInfo.Model> GetCarModelAll()
        {
            using (SqlDataReader dr = SqlHelpers.CarInfo.ExecuteReader("GetDataAll", false, new SqlParameter("tableName", "[dbo].[car_model]")))
            {
                while (dr.Read())
                {
                    Model.CarInfo.Model ci = new Model.CarInfo.Model();
                    ci.Id = dr["id"].ToString();
                    ci.Name = dr["name"].ToString();
                    ci.IsImported = Convert.ToBoolean(dr["isImported"]);
                    ci.BrandId = dr["brandId"].ToString();
                    if (dr["guidance"] != DBNull.Value && dr["guidance"] != null)
                        ci.Guidance = Convert.ToDouble(dr["guidance"]);
                    else
                        ci.Guidance = 0;
                    yield return ci;
                }
            }
        }
        public IEnumerable<Model.CarInfo.Model> GetCarModelById(string id)
        {
            using (SqlDataReader dr = SqlHelpers.CarInfo.ExecuteReader("GetDataById", false, new SqlParameter("tableName", "[dbo].[car_model]"), new SqlParameter("id", id)))
            {
                while (dr.Read())
                {
                    Model.CarInfo.Model ci = new Model.CarInfo.Model();
                    ci.Id = dr["id"].ToString();
                    ci.Name = dr["name"].ToString();
                    ci.IsImported = Convert.ToBoolean(dr["isImported"]);
                    ci.BrandId = dr["brandId"].ToString();
                    if (dr["guidance"] != DBNull.Value && dr["guidance"] != null)
                        ci.Guidance = Convert.ToDouble(dr["guidance"]);
                    else
                        ci.Guidance = 0;
                    yield return ci;
                }
            }
        }
    }
}
