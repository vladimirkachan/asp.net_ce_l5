using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Models.Models
{
    public class ThickModel
    {
        public string Company { get; set; }
        public int Employees { get; set; }
        public int Salary { get; set; }
        public int TotalSalary => Employees * Salary;

        public ThickModel(string company, int employees, int salary)
        {
            Company = company;
            Employees = employees;
            Salary = salary;
        }
    }
}
