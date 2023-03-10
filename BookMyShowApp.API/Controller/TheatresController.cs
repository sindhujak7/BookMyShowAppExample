using BookMyShow.Data;
using BookMyShow.Data.ViewModels;
using BookMyShowApp.API.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BookMyShowApp.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheatresController : ControllerBase
    {
        private readonly ITheatres theatres;
        public TheatresController(ITheatres theatres)
        {
            this.theatres = theatres;
        }

        [HttpGet("cityid")]
        public Task<IEnumerable<Theatre>> Get(int cityid)
        {
            return this.theatres.GetTheatres(cityid);
        }


    }
}
