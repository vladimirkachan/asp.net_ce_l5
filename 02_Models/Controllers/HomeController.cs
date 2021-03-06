using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace _02_Models.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new PlainModel {Company="BSA", Employees=33,Salary=50000};
            ViewData["totalSalary"] = model.Employees * model.Salary;
            ViewData["company"] = model.Company;
            ViewData["employees"] = model.Employees;
            return View();
        }
    }
}
