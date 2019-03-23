using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using CityFlow.Core.Entity.Enums;

namespace CityFlow.Core.Entity
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public VehicleTypeEnum AvailiableVehicleType { get; set; }
    }
}
