using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityFlow.Core.Entity;
using CityFlow.Infrastructure.Commands;
using CityFlow.Infrastructure.Data;
using CityFlow.Infrastructure.Repositories.Interfaces;
using CityFlow.Infrastructure.Services.Interfaces;

namespace CityFlow.Infrastructure.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IRepository<Vehicle> _vehicleRepository ;

        public VehicleService(IRepository<Vehicle> vehicleRepo)
        {
            _vehicleRepository = vehicleRepo;
        }
        
        public async Task<int> AddVehicleAsync(VehicleToAdd vehicleToAdd)
        {
            var vehicle = new Vehicle()
            {
                Name = vehicleToAdd.Name,
                Price = vehicleToAdd.Price,
                Type = vehicleToAdd.Type, 
                GearBoxType = vehicleToAdd.GearBoxType,
                Longitude = vehicleToAdd.Longitude,
                Latitude = vehicleToAdd.Latitude,
                IsAvailiable = vehicleToAdd.IsAvailiable,
                Description = vehicleToAdd.Description,
                NumberOfSeats = vehicleToAdd.NumberOfSeats,
            };
            await _vehicleRepository.AddAsync(vehicle);
            return vehicle.Id;
        }

        public async Task UpdateVehicleAsync(Vehicle vehicle)
        {
            await _vehicleRepository.Update(vehicle);
        }

        public async Task<Vehicle> GetVehicleByIdAsync(int vehicleId)
        {
            return await _vehicleRepository.GetByIdAsync(vehicleId);
        }

        public async Task<IEnumerable<Vehicle>> GetAllVehiclesAsync()
        {
            var vehicles = await _vehicleRepository
                .GetAllAsNoTrackingAsync();
            return vehicles;
        }
    }
}