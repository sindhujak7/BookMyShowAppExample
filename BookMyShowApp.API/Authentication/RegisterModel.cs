using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShowApp.API.Authentication
{
    public class RegisterModel
    {
        
        public int? UserId { get; set; }

        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "PhoneNumber is required")]
        public string Phonenumber { get; set; }

        public string Address { get; set; }

        public string City { get; set; }


    }
}
