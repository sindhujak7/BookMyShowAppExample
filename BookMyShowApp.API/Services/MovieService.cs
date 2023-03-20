using BookMyShow.Data;
using BookMyShow.Data.ViewModels;
using BookMyShowApp.API.Interface;

namespace BookMyShowApp.API.Services
{
    public class MovieService : IMovies
    {
        private readonly BookMyShowContext _context;

        public MovieService(  BookMyShowContext context) {
        this._context = context;
        }
        public async Task<IEnumerable<MoviesModel>> GetMoviesList(int CityId, int? LanguageId)
        {
            var movieslist = (from mv in _context.Movies
                             join ct in _context.MovieCertificateTypes on mv.CertificateTypeId equals ct.Id
                             join mld in _context.MovieLanguageDetails on mv.Id equals mld.MovieId
                             join ln in _context.Languages on mld.LanguageId equals ln.Id
                             join th in _context.Theatres on mld.TheatreId equals th.Id
                             join cty in _context.Cities on th.CityId equals cty.Id
                             where cty.Id == CityId && mv.AvailabilityStatus==true &&   (LanguageId==null|| ln.Id == LanguageId)
                              select new MoviesModel
                             {
                                 Id= mv.Id,
                                 AvailabilityStatus= mv.AvailabilityStatus,
                                 CertificateTypeId= mv.CertificateTypeId,
                                 CertificateTypeName=ct.Name,
                                 MovieName=mv.Name,
                                 ReleaseDate=mv.ReleaseDate,
                                 ContentHours=mv.ContentHours,
                                 Rating=mv.Rating,
                                 LanguageId=mld.LanguageId,
                                 CityName=cty.Name,
                                 LanguageName=ln.Name,
                                 CityId=ct.Id




                             });

            return movieslist;
        }
    }
}
