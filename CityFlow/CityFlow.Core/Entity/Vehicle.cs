using CityFlow.Core.Entity.Enums;

namespace CityFlow.Core.Entity
{
    public class Vehicle : BaseEntity
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
