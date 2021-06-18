using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_CodeInsertions.Models;
using Microsoft.AspNetCore.Mvc;

namespace _04_CodeInsertions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<PlainModel> models = new()
            {
                new PlainModel{Company="Info Sapiens", Employees = 88, Salary=9000},
                new PlainModel{Company = "BSA", Employees = 33, Salary=100000},
                new PlainModel{Company="CATI", Employees=13,Salary=6000}
            };
            return View(models);
        }
    }
}
