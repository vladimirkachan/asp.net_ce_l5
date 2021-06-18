using System.Collections.Generic;
using _05_Routes.Models;
using Microsoft.AspNetCore.Mvc;

namespace _05_Routes.Controllers
{
    public class CallCenterController : Controller
    {
        public IActionResult Companies()
        {
            var models = new List<PlainModel>
            {
                new() {Company = "Info Sapiens", Employees = 89, Salary = 15000},
                new() {Company = "Cati Call Center", Employees = 13, Salary = 6000},
                new() {Company = "IM Data", Employees = 40, Salary = 8000}
            };

            return View(models);
        }
    }
}
