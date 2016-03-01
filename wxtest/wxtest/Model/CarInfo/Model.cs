namespace wxtest.Model.CarInfo
{
    public class Model
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsImported { get; set; }
        public string BrandId { get; set; }
        public double Guidance { get; set; }
        public Model()
        {
            IsImported = false;
        }
    }
}
