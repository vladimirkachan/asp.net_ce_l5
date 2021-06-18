﻿using System.Collections.Generic;
using _05_Routes.Models;
using Microsoft.AspNetCore.Mvc;

namespace _05_Routes.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Companies()
        {
            List<PlainModel> models = new()
            {
                new() { Company = "Toyota", Employees = 50000, Salary = 20000 },
                new() { Company = "Audi", Employees = 55000, Salary = 30000 },
                new() { Company = "Volvo", Employees = 10000, Salary = 8000 }
            };

            return View(models);
        }
    }
}
