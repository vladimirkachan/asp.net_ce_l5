using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace _01_Models.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    var model = new PlainModel{Company="Info Sapiens", Employees=88,Salary=10000};
        //    return $"Company: {model.Company}\nEmployees: {model.Employees}\nTotal Salary: {model.Employees * model.Salary}";
        //}
        public string Index()
        {
            ThickModel model = new("IS", 90, 12000);
            return $"Company: {model.Company}\nEmployees: {model.Employees}\nTotal Salary: {model.TotalSalary}";
        }
    }
}
