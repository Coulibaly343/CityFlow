using System.Collections.Generic;
using System.Threading.Tasks;
using CityFlow.Core.Entity;
using CityFlow.Core.Entity.Enums;

namespace CityFlow.Infrastructure.Services.Interfaces
{
    public interface IVehicleService
    {
        Task<int> AddVehicleAsync(VehicleTypeEnum typeEnum, string longitude
            , string latitude, bool isAvailable);

        Task UpdateVehicleAsync();
        Task<Vehicle> GetVehicleByIdAsync(int vehicleId);
        Task<IEnumerable<Vehicle>> GetAllVehiclesAsync();
        
    }
}