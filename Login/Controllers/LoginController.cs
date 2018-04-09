using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Login.Models;

namespace Login.Controllers
{
    public class LoginController : Controller
    {

[HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProcessLogin(LoginViewModel lvm)
        {
            if(false)
            {
                return View("LoginWasWrong", lvm);
            }
            else
            {
                return View("LoggedIn", lvm);
            }
}
    }
}