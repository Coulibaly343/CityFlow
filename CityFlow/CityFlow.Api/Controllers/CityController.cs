using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CityFlow.Infrastructure.Commands;
using CityFlow.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CityFlow.Api.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityService _cityService;
        
        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet("cities")]
        public async Task<IActionResult> GetAllCitiesWithVehicles()
        {
            try
            {
                var cities = await _cityService.GetAllCities();
                return Json(cities);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }        
    }
}