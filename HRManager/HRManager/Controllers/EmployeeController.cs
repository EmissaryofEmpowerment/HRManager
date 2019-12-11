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
            Employee FirstPerson = new Employee()
            {
                FirstName = "Gustav",
                LastName = "Heinmarsh",
                Address = "45728 Marshall Lane Bentonville, AK ",
                Department = Constants.Department.Distribution,
               Shift = Constants.Shift.Day
            };
            Employee SecondPerson = new Employee()
            { FirstName = "Matoape",
                LastName = "Fengitoa",
                Address = "898 Cedar Grove Blvd, Portland, ME",
                Department = Constants.Department.Distribution,
                Shift = Constants.Shift.Day,
                FavoriteColor = "White",
                Manager = FirstPerson
            };
            Employee ThirdPerson = new Employee()
            {
                FirstName = "Li",
                LastName = "Chen",
                Address = "7882 Blue Lake Rd, Boulder, CO",
                Department = Constants.Department.Service,
                Shift = Constants.Shift.Night,
                FavoriteColor = "Red",
            };
            Employee FourthPerson = new Employee()
            {
                FirstName = "Robert",
                LastName = "Mbuntu",
                Address = "3499 Crescent Moon Dr, Lincoln, NE",
                Department = Constants.Department.Service,
                Shift = Constants.Shift.Day,
                Manager = ThirdPerson
            };
            pointer.Add(FirstPerson);
            pointer.Add(SecondPerson);
            pointer.Add(ThirdPerson);
            pointer.Add(FourthPerson);

            EmpList.Employee_List = pointer;
              return View(EmpList);
        }
        public IActionResult IndividualTeamMember()
        {
            Employee individual = new Employee()
            {
                FirstName = "Pierre",
                LastName = "Roucheau",
            };
            return View(individual);
        }
        
        //public IActionResult CreateRecord(int id = 0)
        //{
        //    if (id==0)
        //    {
        //        return View(new Employee());
        //    }
        //    else
        //    {
        //        return View(_contextDB.Employees);
        //    }
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRecord
            ([Bind("EmployeeID, FirstName, LastName")]
            HRManager.Models.Employee employee)
        {
            if (ModelState.IsValid)
            {
                if (employee.EmployeeId == 0)
                {
                    _contextDB.Add(employee);
                }
                else
                {
                    _contextDB.Update(employee);
                }
                await _contextDB.SaveChangesAsync();
                    return RedirectToAction(nameof(employee));
                
            }
            return View();
        }
        public async Task<IActionResult> Delete(int? id)
        {
            var employee = await _contextDB.Employees.FindAsync(id);
            _contextDB.Employees.Remove(employee);
            await _contextDB.SaveChangesAsync();
            return RedirectToAction(nameof(AllEmployees));
                }
    }
}
