using BookMyShow.Data;
using BookMyShowApp.API.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace BookMyShowApp.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        public readonly ICities _cities;

        public CitiesController(ICities city)
        {
            _cities = city;
            
        }
        [HttpGet]
        public  Task<IEnumerable<City>> Get()
        {
            return _cities.GetCities();


        }
     
    }
}
