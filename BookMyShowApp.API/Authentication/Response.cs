using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShowApp.API.Authentication
{
    public class Response
    {
        public bool Status { get; set; }
        public string Message { get; set; }

        public virtual Tokens Tokens { get; set; }
    }

    public class Tokens
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }

}
