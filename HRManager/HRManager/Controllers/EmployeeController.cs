using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRManager.Models.ViewModels;
using HRManager.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HRManager.Data;

namespace HRManager.Controllers
{
    public class EmployeeController: Controller
    {
        private readonly EmployeeContextDB _contextDB;
        public EmployeeController(EmployeeContextDB contextDB)
        {
            _contextDB = contextDB;
        }
        public IActionResult AllEmployees()
        {
            EmployeeViewModel EmpList = new EmployeeViewModel();
            List<Employee> pointer = new List<Employee>();
            EmpList.Employee_List = pointer;
              return View(EmpList);
        }
        public IActionResult IndividualTeamMember()
        {
            Employee individual = new Employee();
            return View(individual);
        }
        public IActionResult CreateRecord(int id = 0)
        {
            return View(new Employee());
        }
    }
}
