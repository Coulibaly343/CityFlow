using System;
using System.Threading.Tasks;
using CityFlow.Core.Entity;
using CityFlow.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CityFlow.Api.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{userId}")]
        public async Task<User> GetUserById(int userId)
        {
            return await _userService.GetUserByIdAsync(userId);
        }
    }
}