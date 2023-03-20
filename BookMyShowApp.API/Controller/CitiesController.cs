using BookMyShow.Data;
using BookMyShowApp.API.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using BookMyShowApp.API.Services;
using Microsoft.Extensions.Options;

namespace BookMyShowApp.API.Controller
{
   [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ILogin _login;
        public readonly ICities _cities;
        public CitiesController(ICities city)
        {
            _cities = city;          //  _login = login; 

        }
        [HttpGet]
        public  Task<IEnumerable<City>> Get()
        {
            return _cities.GetCities();


        }
     
    }
}
