using System.Threading.Tasks;
using CityFlow.Core.Entity;
using CityFlow.Infrastructure.Repositories.Interfaces;
using CityFlow.Infrastructure.Services.Interfaces;

namespace CityFlow.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepo;

        public UserService(IRepository<User> userRepo)
        {
            _userRepo = userRepo;
        }
        
        public Task<int> AddUserAsync(string name)
        {
            throw new System.NotImplementedException();
        }

        public async Task<User> GetUserByIdAsync(int userId)
        {
            return await _userRepo.GetByIdAsync(userId);
        }
    }
}