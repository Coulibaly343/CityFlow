using System.Collections.Generic;
using CityFlow.Core.Entity;

namespace CityFlow.Infrastructure.Commands
{
    public class CityWithVehiclesToAdd
    {
        public string Name { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}