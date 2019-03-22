using System.Collections.Generic;

namespace CityFlow.Core.Entity
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Vehicle> Vehicles  { get; set; }
    }
}
