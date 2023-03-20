using BookMyShow.Data;
using BookMyShowApp.API.Authentication;
using BookMyShowApp.API.Interface;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BookMyShowApp.API.Services
{
    public class LoginService : ILogin
    {
        private readonly BookMyShowContext _context;
        private readonly IConfiguration iconfiguration;

        public LoginService(BookMyShowContext context, IConfiguration iconfiguration)
        {
            _context = context;
            this.iconfiguration = iconfiguration;
        }

        public Response Login(LoginModel model)
        {
            try
            {
                Response response = new Response();
                if (model != null)
                {
                    string password = Encryption.EncodePasswordToBase64(model.Password);
                    var result = _context.LoginDetails.Where(x => x.UserName.ToLower() == model.Username.ToLower() && x.Password == password).ToList();
                    if (result.Count > 0)
                    {
                        response.Status = true;
                        response.Message = "Valid User";

                        // Else we generate JSON Web Token
                        var tokenHandler = new JwtSecurityTokenHandler();
                        var tokenKey = Encoding.UTF8.GetBytes(iconfiguration["JWT:Key"]);
                        var tokenDescriptor = new SecurityTokenDescriptor
                        {
                            Subject = new ClaimsIdentity(new Claim[]
                                      {
                            new Claim(ClaimTypes.Name, model.Username)
                                      }),
                            Expires = DateTime.UtcNow.AddMinutes(10),
                            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
                        };
                        var token = tokenHandler.CreateToken(tokenDescriptor);
                        Tokens tokenvalue = new Tokens();
                        tokenvalue.Token = tokenHandler.WriteToken(token);
                        response.Tokens = tokenvalue;
                        return response;

                    }
                    else
                    {
                        response.Status = false;
                        response.Message = "Invalid User";

                    }

                }
                return response;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task Registration(RegisterModel model ,IServiceScopeFactory serviceScopeFactory)
        {
            try
            {
               

               


                await Task.Delay(5000);
                using (var scope = serviceScopeFactory.CreateScope())
                {

                    var cst = new Customer()
                    {
                        Name = model.Username,
                        Address = model.Address,
                        City = model.City,
                        Email = model.Email,
                        PhoneNumber = model.Phonenumber


                    };
                    await _context.Customers.AddAsync(cst);
                    await _context.SaveChangesAsync();

                    model.UserId = cst.Id;

                    var login = new LoginDetails()
                    {
                        UserName = model.Username,
                        Password = Encryption.EncodePasswordToBase64(model.Password),
                        CustomerId = (int)model.UserId,
                        JwtToken = ""
                    };

                    await _context.LoginDetails.AddAsync(login);
                    await _context.SaveChangesAsync();


                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
