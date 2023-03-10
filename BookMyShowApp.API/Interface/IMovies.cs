using BookMyShow.Data;
using BookMyShow.Data.ViewModels;
namespace BookMyShowApp.API.Interface
{
    public interface IMovies
    {
        public Task<IEnumerable<MoviesModel>> GetMoviesList(int CityId, int? LanguageId);
    }
}
