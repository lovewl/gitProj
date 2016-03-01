using System.Collections.Generic;
using wxtest.DAL.CarInfo;
using wxtest.Model.CarInfo;

namespace wxtest.BLL.CarInfo
{
    public class CompanyService
    {
        private CompanyDAO _dao = new CompanyDAO();
        public int AddCarCompany(string name)
        {
            return _dao.AddCarCompany(name);
        }
        public int DelCarCompanyById(string id)
        {
            return _dao.DelCarCompanyById(id);
        }
        public int UpdateCarCompanyById(string id, string name)
        {
            return _dao.UpdateCarCompanyById(id, name);
        }
        public IEnumerable<Company> GetCarCompanyAll()
        {
            return _dao.GetCarCompanyAll();
        }
        public IEnumerable<Company> GetCarCompanyById(string id)
        {
            return _dao.GetCarCompanyById(id);
        }
    }
}
