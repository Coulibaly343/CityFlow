using System.Collections.Generic;
using System.Threading.Tasks;
using CityFlow.Core.Entity;
using CityFlow.Core.Entity.Enums;
using CityFlow.Infrastructure.Commands;

namespace CityFlow.Infrastructure.Services.Interfaces
{
    public interface IVehicleService
    {
        Task<int> AddVehicleAsync(VehicleToAdd vehicleToAdd);

        Task UpdateVehicleAsync(Vehicle vehicle);
        Task<Vehicle> GetVehicleByIdAsync(int vehicleId);
        Task<IEnumerable<Vehicle>> GetAllVehiclesAsync();
        
    }
}