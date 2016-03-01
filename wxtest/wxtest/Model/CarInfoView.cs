using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wxtest.BLL.CarInfo;
using wxtest.Model.CarInfo;

namespace wxtest.Model
{
    public class CarInfoView
    {
        public IEnumerable<Brand> BrandList { get; set; }
        public IEnumerable<Company> CompanyList { get; set; }
        public IEnumerable<CarInfo.Model> ModelList { get; set; }
        public IEnumerable<DetailInfo> TypeList { get; set; }
        public CarInfoView()
        {
            BrandService _serviceBrand = new BrandService();
            BrandList = _serviceBrand.GetCarBrandAll();
            ModelService _serviceModel = new ModelService();
            ModelList = _serviceModel.GetCarModelAll();
            DetailInfoService _serviceType = new DetailInfoService();
            TypeList = _serviceType.GetCarInfoAll();
        }
    }
}
