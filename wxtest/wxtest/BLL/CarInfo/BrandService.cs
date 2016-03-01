using System.Collections.Generic;
using wxtest.DAL.CarInfo;
using wxtest.Model.CarInfo;

namespace wxtest.BLL.CarInfo
{
    public class BrandService
    {
        private BrandDAO _dao = new BrandDAO();
        public int AddCarBrand(string name, string initial)
        {
            return _dao.AddCarBrand(name, initial);
        }
        public int DelCarBrandById(string id)
        {
            return _dao.DelCarBrandById(id);
        }
        public int UpdateCarBrandById(string id, string name, string initial)
        {
            return _dao.UpdateCarBrandById(id, name, initial);
        }
        public IEnumerable<Brand> GetCarBrandAll()
        {
            return _dao.GetCarBrandAll();
        }
        public IEnumerable<Brand> GetCarBrandById(string id)
        {
            return _dao.GetCarBrandById(id);
        }
    }
}
