using BookMyShowApp.API.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BookMyShowApp.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]

    public class MoviesController : ControllerBase
    {

        private readonly IMovies _movies;
        public MoviesController(IMovies movies) {
        this._movies= movies;
        
        }
        [HttpGet]
        [Route("api/Movies/{CityId}/{LanguageId}")]
        public IActionResult Get(int CityId,int?LanguageId)
        {
            var result =_movies.GetMoviesList(CityId,LanguageId);

            return Ok(result);
        }
    }
}
