using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewMathWizard.Models;

namespace NewMathWizard.Controllers
{
    public class HomeController : Controller
    {
        public string Add(int num1, int num2, int answer)
        {
            answer = num1 + num2;
            return $"{num1} plus {num2} equals {answer}";
        }
        public string subtract(int num1, int num2, int answer)
        {
            answer = num1 - num2;
            return $"{num1} Minus {num2} equals {answer}";
        } 
        public string Multiply(int num1, int num2, int answer)
        {
            answer = num1 * num2;
            return $"{num1} Times {num2} equals {answer}";
        }
        public string Divide(int num1, int num2, int answer)
        {
            answer = num1 / num2;
    
            return $"{num1} divided by {num2} equals {answer}";
        }       
        
        public string modulus(int num1, int num2, int answer)
        {
            answer = num1 % num2;
            return $"{num1} is {num2} = {answer}";
        }
       
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
