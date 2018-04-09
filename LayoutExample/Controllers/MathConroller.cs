using System;
using Microsoft.AspNetCore.Mvc;

namespace LayoutExample.Controllers
{
    public class MathController : Controller
    {
        [HttpGet]
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Input()
        {
            return View();
        }
    }    

}