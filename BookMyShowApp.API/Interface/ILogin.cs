using BookMyShowApp.API.Authentication;

namespace BookMyShowApp.API.Interface
{
    public interface ILogin
    {
        Response Login(LoginModel model);

        Task Registration(RegisterModel model , IServiceScopeFactory serviceScopeFactory);
    }
}
