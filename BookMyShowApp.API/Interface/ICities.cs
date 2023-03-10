using BookMyShow.Data;

namespace BookMyShowApp.API.Interface
{
    public interface ICities
    {
        public Task<IEnumerable<City>> GetCities();
    }
}
