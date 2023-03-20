using BookMyShowApp.API.Authentication;
using BookMyShowApp.API.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BookMyShowApp.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly ILogin _login;
        private readonly ILogger<AuthenticationController> _logger;
        private readonly IServiceScopeFactory serviceScopeFactory;
        public AuthenticationController(ILogin login, IServiceScopeFactory serviceScopeFactory ,ILogger<AuthenticationController> logger)
        {
            this._login = login;
            this.serviceScopeFactory = serviceScopeFactory;
            this._logger = logger;
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {

            try
            {

                var result=this._login.Login(model);
                _logger.LogInformation("Login page visited.");
                return Ok(result);

            }
            catch(Exception ex) {
                throw ex;

            }
        }


        [Route("register")]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {

            try
            {

               await Task.Run(() => _login.Registration(model, serviceScopeFactory));
                return Ok();



            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

    }
}
