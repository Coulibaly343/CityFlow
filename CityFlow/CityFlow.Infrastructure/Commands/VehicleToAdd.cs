using CityFlow.Core.Entity.Enums;

namespace CityFlow.Infrastructure.Commands
{
    public class VehicleToAdd
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public VehicleTypeEnum Type { get; set; }
        public GearBoxTypeEnum GearBoxType { get; set; }
        public bool IsAvailiable { get; set; }
        public string Description { get; set; }
        public byte NumberOfSeats { get; set; }
    }
}