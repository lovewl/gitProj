using System.Collections.Generic;
using wxtest.DAL.CarInfo;

namespace wxtest.BLL.CarInfo
{
    public class ModelService
    {
        private ModelDAO _dao = new ModelDAO();
        public int AddCarModel(string name, bool isImported, string brandId, double guidance)
        {
            return _dao.AddCarModel(name, isImported, brandId, guidance);
        }
        public int DelCarModelById(string id)
        {
            return _dao.DelCarModelById(id);
        }
        public int UpdateCarModelById(string id, string name, bool isImported, string brandId, double guidance)
        {
            return _dao.UpdateCarModelById(id, name, isImported, brandId, guidance);
        }
        public IEnumerable<Model.CarInfo.Model> GetCarModelAll()
        {
            return _dao.GetCarModelAll();
        }
        public IEnumerable<Model.CarInfo.Model> GetCarModelById(string id)
        {
            return _dao.GetCarModelById(id);
        }
    }
}
