using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Login.Models;

namespace Login.Controllers
{
    public class logincontroller : Controller
    {
        public IActionResult Login()
        {
             return View();
        }

        public IActionResult loginfail()
        {
            return View();
        }
        
        public IActionResult loginsuccessful()
        {
            return View();
        }
    }
}