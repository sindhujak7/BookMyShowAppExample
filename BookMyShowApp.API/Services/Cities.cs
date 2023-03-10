using BookMyShow.Data;
using BookMyShowApp.API.Interface;
using Microsoft.EntityFrameworkCore;

namespace BookMyShowApp.API.Services
{
    public class Cities : ICities
    {
        private readonly BookMyShowContext _context;
        public Cities(BookMyShowContext context) {
            _context = context;
        }
        public async Task<IEnumerable<City>> GetCities()
        {
          var cities=  await _context.Cities.ToListAsync();
            return cities;
            
        }
    }
}
