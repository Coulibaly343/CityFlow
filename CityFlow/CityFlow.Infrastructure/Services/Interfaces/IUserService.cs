using System.Threading.Tasks;
using CityFlow.Core.Entity;

namespace CityFlow.Infrastructure.Services.Interfaces
{
    public interface IUserService
    {
        Task<int> AddUserAsync(string name);
        Task<User> GetUserByIdAsync(int userId);
    }
}