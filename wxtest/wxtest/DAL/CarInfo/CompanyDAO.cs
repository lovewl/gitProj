using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using wxtest.Model.CarInfo;

namespace wxtest.DAL.CarInfo
{
    public class CompanyDAO
    {
        public int AddCarCompany(string name)
        {
            var guid = Guid.NewGuid();
            return SqlHelpers.CarInfo.ExecuteNonQuery("AddCarCompany", false, new SqlParameter("id", guid), new SqlParameter("name", name));
        }
        public int DelCarCompanyById(string id)
        {
            return SqlHelpers.CarInfo.ExecuteNonQuery("DelCarCompanyById", false, new SqlParameter("id", id));
        }
        public int UpdateCarCompanyById(string id, string name)
        {
            return SqlHelpers.CarInfo.ExecuteNonQuery("UpdateCarCompanyById", false, new SqlParameter("id", id), new SqlParameter("name", name));
        }
        public IEnumerable<Company> GetCarCompanyAll()
        {
            using (SqlDataReader dr = SqlHelpers.CarInfo.ExecuteReader("GetCarCompanyAll", false, null))
            {
                while (dr.Read())
                {
                    Company ci = new Company();
                    ci.Id = dr["id"].ToString();
                    ci.Name = dr["name"].ToString();
                    yield return ci;
                }
            }
        }
        public IEnumerable<Company> GetCarCompanyById(string id)
        {
            using (SqlDataReader dr = SqlHelpers.CarInfo.ExecuteReader("GetCarCompanyById", false, new SqlParameter("id", id)))
            {
                while (dr.Read())
                {
                    Company ci = new Company();
                    ci.Id = dr["id"].ToString();
                    ci.Name = dr["name"].ToString();
                    yield return ci;
                }
            }
        }
    }
}
