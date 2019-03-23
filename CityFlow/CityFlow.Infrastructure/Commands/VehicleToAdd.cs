using CityFlow.Core.Entity.Enums;

namespace CityFlow.Infrastructure.Commands
{
    public class VehicleToAdd
    {
        public VehicleTypeEnum Type { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public bool IsAvailiable { get; set; }
    }
}