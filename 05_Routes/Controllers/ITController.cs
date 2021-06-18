using System.Collections.Generic;
using _05_Routes.Models;
using Microsoft.AspNetCore.Mvc;

namespace _05_Routes.Controllers
{
    public class ITController : Controller
    {
        public IActionResult Companies()
        {
            List<PlainModel> models = new ()
            {
                new () {Company = "Yandex", Employees = 25000, Salary = 10000},
                new () {Company = "Kaspersky", Employees = 12000, Salary = 20000},
                new () {Company = "Lanet", Employees = 3000, Salary = 17000}
            };

            return View(models);
        }
    }
}
