using System;
using System.Collections.Generic;
using wxtest.DAL.CarInfo;
using wxtest.Model.CarInfo;

namespace wxtest.BLL.CarInfo
{
    public class DetailInfoService
    {
        private DetailInfoDAO _dao = new DetailInfoDAO();
        public int AddCarInfo(string name, DateTime productionTime, string modelId, string paramsBaseId, string bodyId, string engineId, bool productionStop = false, double guidance = 0, double referencePrice = 0)
        {
            return _dao.AddCarInfo(name, productionTime, modelId, paramsBaseId, bodyId, engineId, productionStop, guidance, referencePrice);
        }
        public int DelCarInfoById(string id)
        {
            return _dao.DelCarInfoById(id);
        }
        public int UpdateCarInfoById(string id, string name, DateTime productionTime, string modelId, string paramsBaseId, string bodyId, string engineId, bool productionStop = false, double guidance = 0, double referencePrice = 0)
        {
            return _dao.UpdateCarInfoById(id, name, productionTime, modelId, paramsBaseId, bodyId, engineId, productionStop, guidance, referencePrice);
        }
        public IEnumerable<DetailInfo> GetCarInfoAll()
        {
            return _dao.GetCarInfoAll();
        }
        public IEnumerable<DetailInfo> GetCarInfoById(string id)
        {
            return _dao.GetCarInfoById(id);
        }
    }
}
