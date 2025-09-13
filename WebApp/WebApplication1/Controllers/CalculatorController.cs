using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Calculate(double num1, double num2, string operation)
        {
            double result = 0;
            switch (operation)
            {
                case "add": result = num1 + num2; break;
                case "subtract": result = num1 - num2; break;
                case "multiply": result = num1 * num2; break;
                case "divide":
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        ViewBag.Result = "Error: Cannot divide by zero";
                    break;
            }
            ViewBag.Result ??= result; // Only overwrite if not already set
            return View("Index");
        }
    }

}