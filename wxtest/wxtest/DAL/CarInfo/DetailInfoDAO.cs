using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using wxtest.Model.CarInfo;

namespace wxtest.DAL.CarInfo
{
    public class DetailInfoDAO
    {
        public int AddCarInfo(string name, DateTime productionTime, string modelId, string paramsBaseId, string bodyId, string engineId, bool productionStop = false, double guidance = 0, double referencePrice = 0)
        {
            var id = Guid.NewGuid();
            return SqlHelpers.CarInfo.ExecuteNonQuery("AddCarInfo", false
                , new SqlParameter("id", id)
                , new SqlParameter("name", name)
                , new SqlParameter("productionTime", productionTime)
                , new SqlParameter("productionStop", productionStop)
                , new SqlParameter("modelId", modelId)
                , new SqlParameter("paramsBaseId", paramsBaseId)
                , new SqlParameter("bodyId", bodyId)
                , new SqlParameter("engineId", engineId)
                , new SqlParameter("guidance", guidance)
                , new SqlParameter("referencePrice", referencePrice)
                );
        }
        public int DelCarInfoById(string id)
        {
            return SqlHelpers.CarInfo.ExecuteNonQuery("DelCarInfo", false, new SqlParameter("id", id));
        }
        public int UpdateCarInfoById(string id, string name, DateTime productionTime, string modelId, string paramsBaseId, string bodyId, string engineId, bool productionStop = false, double guidance = 0, double referencePrice = 0)
        {
            return SqlHelpers.CarInfo.ExecuteNonQuery("UpdateCarInfoById", false
                , new SqlParameter("id", id)
                , new SqlParameter("name", name)
                , new SqlParameter("productionTime", productionTime)
                , new SqlParameter("modelId", modelId)
                , new SqlParameter("paramsBaseId", paramsBaseId)
                , new SqlParameter("bodyId", bodyId)
                , new SqlParameter("engineId", engineId)
                , new SqlParameter("productionStop", productionStop)
                , new SqlParameter("guidance", guidance)
                , new SqlParameter("referencePrice", referencePrice)
                );
        }
        public IEnumerable<DetailInfo> GetCarInfoAll()
        {
            using (SqlDataReader dr = SqlHelpers.CarInfo.ExecuteReader("GetDataAll", false, new SqlParameter("tableName", "car_info")))
            {
                while (dr.Read())
                {
                    DetailInfo ci = new DetailInfo();
                    ci.Id = dr["id"].ToString();
                    ci.Name = dr["name"].ToString();
                    ci.ProductionTime = Convert.ToDateTime(dr["ProductionTime"]);
                    ci.ModelId = dr["modelId"].ToString();
                    ci.ParamsBaseId = dr["paramsBaseId"].ToString();
                    ci.BodyId = dr["bodyId"].ToString();
                    ci.EngineId = dr["engineId"].ToString();
                    ci.ProductionStop = Convert.ToBoolean(dr["productionStop"]);
                    ci.Guidance = Convert.ToDouble(dr["guidance"]);
                    ci.ReferencePrice = Convert.ToDouble(dr["referencePrice"]);
                    yield return ci;
                }
            }
        }
        public IEnumerable<DetailInfo> GetCarInfoById(string id)
        {
            using (SqlDataReader dr = SqlHelpers.CarInfo.ExecuteReader("GetDataAll", false, new SqlParameter("tableName", "car_info"), new SqlParameter("id", id)))
            {
                while (dr.Read())
                {
                    DetailInfo ci = new DetailInfo();
                    ci.Id = dr["id"].ToString();
                    ci.Name = dr["name"].ToString();
                    ci.ProductionTime = Convert.ToDateTime(dr["ProductionTime"]);
                    ci.ModelId = dr["modelId"].ToString();
                    ci.ParamsBaseId = dr["paramsBaseId"].ToString();
                    ci.BodyId = dr["bodyId"].ToString();
                    ci.EngineId = dr["engineId"].ToString();
                    ci.ProductionStop = Convert.ToBoolean(dr["productionStop"]);
                    ci.Guidance = Convert.ToDouble(dr["guidance"]);
                    ci.ReferencePrice = Convert.ToDouble(dr["referencePrice"]);
                    yield return ci;
                }
            }
        }
    }
}
