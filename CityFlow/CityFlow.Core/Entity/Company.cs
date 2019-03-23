using System.Collections.Generic;
using CityFlow.Core.Entity.Enums;

namespace CityFlow.Core.Entity
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<VehicleTypeEnum> AvailiableVehicleTypes { get; set; }
    }
}
