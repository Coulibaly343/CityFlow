using System.Threading.Tasks;
using CityFlow.Core.Entity;
using CityFlow.Infrastructure.Services.Interfaces;

namespace CityFlow.Infrastructure.Services
{
    public class UserService : IUserService
    {
        public Task<int> AddUserAsync(string name)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> GetUserByIdAsync(int userId)
        {
            throw new System.NotImplementedException();
        }
    }
}