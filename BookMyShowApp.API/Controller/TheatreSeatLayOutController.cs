using BookMyShow.Data;
using BookMyShowApp.API.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BookMyShowApp.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheatreSeatLayOutController : ControllerBase
    {

        private readonly ITheatres theatreseatlayout;

        public TheatreSeatLayOutController(ITheatres theatreseatlayout)
        {
            this.theatreseatlayout = theatreseatlayout;
        }

        [HttpGet("theatreid")]
        public async Task<IEnumerable<TheatreSeatLayOut>> Get(int theatreid)
        {

            var data= await this.theatreseatlayout.GetTheatreSeatLayOuts(theatreid);
            return data;
        }
    }
}
