using System;

namespace wxtest.Model.CarInfo
{
    public class DetailInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime ProductionTime { get; set; }
        public bool ProductionStop { get; set; }
        public double Guidance { get; set; }
        public double ReferencePrice { get; set; }
        public string ModelId { get; set; }
        public string ParamsBaseId { get; set; }
        public string BodyId { get; set; }
        public string EngineId { get; set; }
    }
}
