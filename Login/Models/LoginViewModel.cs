using System;

namespace Login.Models
{
    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password {get; set;}
        public bool LoggedIn{get; set;}

    }
}