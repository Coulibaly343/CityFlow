namespace CityFlow.Core.Entity
{
    public class Vehicle
    {
        public int Id { get; set; }
        public VehicleTypeEnum Type { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public bool IsAvailiable { get; set; }
    }
}
