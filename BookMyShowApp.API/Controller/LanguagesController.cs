using BookMyShowApp.API.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BookMyShowApp.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        private readonly ILanguages _languages;

        public LanguagesController(ILanguages languages)
        {
            _languages = languages;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var languages = _languages.GetLanguages();

            return Ok(languages);
        }
    }
}
