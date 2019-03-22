using System.Threading.Tasks;
using CityFlow.Core.Entity;

namespace CityFlow.Infrastructure.Services.Interfaces
{
    public interface ICityService
    {
        Task<int> AddCityAsync(string name);
        Task<int> AddVehicleToCityAsync(Vehicle vehicle);
        Task<City> GetAllCityById(int cityId);
    }
}