using System.Collections.Generic;
using System.Threading.Tasks;
using CityFlow.Core.Entity;
using CityFlow.Infrastructure.Commands;

namespace CityFlow.Infrastructure.Services.Interfaces
{
    public interface ICityService
    {
        Task<int> AddCityWithVehiclesAsync(CityWithVehiclesToAdd cityWithVehiclesToAdd);
        Task<IEnumerable<City>> GetAllCities();
    }
}