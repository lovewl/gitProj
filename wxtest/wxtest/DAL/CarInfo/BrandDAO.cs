using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using wxtest.Model.CarInfo;

namespace wxtest.DAL.CarInfo
{
    public class BrandDAO
    {
        public int AddCarBrand(string name, string initial)
        {
            var guid = Guid.NewGuid();
            return SqlHelpers.CarInfo.ExecuteNonQuery("AddCarBrand", false, new SqlParameter("id", guid), new SqlParameter("name", name), new SqlParameter("initial", initial));
        }
        public int DelCarBrandById(string id)
        {
            return SqlHelpers.CarInfo.ExecuteNonQuery("DelCarBrandById", false, new SqlParameter("id", id));
        }
        public int UpdateCarBrandById(string id, string name, string initial)
        {
            return SqlHelpers.CarInfo.ExecuteNonQuery("UpdateCarBrandById", false, new SqlParameter("id", id), new SqlParameter("name", name), new SqlParameter("initial", initial));
        }
        public IEnumerable<Brand> GetCarBrandAll()
        {
            using (SqlDataReader dr = SqlHelpers.CarInfo.ExecuteReader("GetCarBrandAll", false, null))
            {
                while (dr.Read())
                {
                    Brand ci = new Brand();
                    ci.Id = dr["id"].ToString();
                    ci.Name = dr["name"].ToString();
                    ci.Initial = dr["initial"].ToString();
                    yield return ci;
                }
            }
        }
        public IEnumerable<Brand> GetCarBrandById(string id)
        {
            using (SqlDataReader dr = SqlHelpers.CarInfo.ExecuteReader("GetCarBrandById", false, new SqlParameter("id", id)))
            {
                while (dr.Read())
                {
                    Brand ci = new Brand();
                    ci.Id = dr["id"].ToString();
                    ci.Name = dr["name"].ToString();
                    ci.Initial = dr["initial"].ToString();
                    yield return ci;
                }
            }
        }
        public IEnumerable<Brand> GetCarBrandByName(string name)
        {
            using (SqlDataReader dr = SqlHelpers.CarInfo.ExecuteReader("GetCarBrandByName", false, new SqlParameter("name", name)))
            {
                while (dr.Read())
                {
                    Brand ci = new Brand();
                    ci.Id = dr["id"].ToString();
                    ci.Name = dr["name"].ToString();
                    ci.Initial = dr["initial"].ToString();
                    yield return ci;
                }
            }
        }
    }
}
