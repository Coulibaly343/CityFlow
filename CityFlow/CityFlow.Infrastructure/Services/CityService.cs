using System.Collections.Generic;
using System.Threading.Tasks;
using CityFlow.Core.Entity;
using CityFlow.Infrastructure.Commands;
using CityFlow.Infrastructure.Repositories.Interfaces;
using CityFlow.Infrastructure.Services.Interfaces;

namespace CityFlow.Infrastructure.Services
{
    public class CityService : ICityService
    {
        private readonly IRepository<City> _cityRepo;

        public CityService(IRepository<City> cityRepo)
        {
            _cityRepo = cityRepo;
        }
        
        public async Task<int> AddCityWithVehiclesAsync(CityWithVehiclesToAdd cityWithVehiclesToAdd)
        {
            var city = new City()
            {
                Name = cityWithVehiclesToAdd.Name,
                Vehicles = cityWithVehiclesToAdd.Vehicles
            };
            await _cityRepo.AddAsync(city);
            return city.Id;
        }

        public async Task<IEnumerable<City>> GetAllCities()
        {
            var allCities = await _cityRepo.GetAllAsNoTrackingAsync();
            return allCities;
        }
    }
}