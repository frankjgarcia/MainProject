using System;
using Microsoft.AspNetCore.Mvc;

namespace MathOperand.Controllers
{
    public class MathController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Input(){
            return View();
        }
    }
}