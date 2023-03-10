using BookMyShow.Data;
using BookMyShow.Data.ViewModels;

namespace BookMyShowApp.API.Interface
{
    public interface ITheatres
    {
       Task<IEnumerable<Theatre>> GetTheatres(int CityId);

        
        Task<IEnumerable<SeatCategoryWithPriceDetails>> GetSeatCategoryWithPriceDetails(int TheatreId);

        Task<IEnumerable<TheatreShow>> GetSeatShows(int TheatreId);       

        Task<IEnumerable<TheatreSeatLayOut>> GetTheatreSeatLayOuts(int TheatreId);


    }
}
