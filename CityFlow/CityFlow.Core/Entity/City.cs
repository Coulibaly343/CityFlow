using System.Collections.Generic;

namespace CityFlow.Core.Entity
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Vehicle> Vehicles  { get; set; }
    }
}
