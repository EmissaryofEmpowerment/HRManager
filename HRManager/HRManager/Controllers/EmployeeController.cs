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
            if (id==0)
            {
                return View(new Employee());
            }
            else
            {
                return View(_contextDB.Employees);
            }
        }

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
