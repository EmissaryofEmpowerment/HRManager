using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRManager.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HRManager.Models.ViewModels;

namespace HRManager.Controllers
{
    public class EmployeeController: Controller
    {
        public IActionResult AllEmployees()
        {

            Employee employee = new Employee()
            {
                EmployeeId = 1,
                FirstName = "Ryan",
                LastName = "Armstrong",
                Address = "837 E 2600 N North Ogden, UT 84414",
                Email = "ryscottarmstrong@gmail.com",
                PhoneNumber = "801-900-5981",
                Position = "Software Developer",
                Department = HRManager.Models.Constants.Department.Information_Technology,
                StartDate = new DateTime(2017, 04, 03),
                EndDate = new DateTime(),
                EmploymentStatus = HRManager.Models.Constants.Employment_Status.Owner,
                Shift = HRManager.Models.Constants.Shift.Day,
                Manager = new Employee()
                {
                    FirstName = "Heavenly",
                    LastName = "Father",
                },
                ////Team Member Photo (above my skill level at present)
                FavoriteColor = "I like colors",
                PermissionLevel = HRManager.Models.Constants.PermissionLevel.Low,
                UserName = "RyScott",
                PassWord = "Uint%43K8"
            };
            Employee _2ndEmployee = new Employee()
            { EmployeeId = employee.EmployeeId++,
                FirstName = "Audrian",
                LastName = "Adams",
                Address = "856 Movie Street",
                Email = "AudriAdams@restaurant.com",
                PhoneNumber = "555-555-5555",
                Position = "Scientist Food",
                Department = HRManager.Models.Constants.Department.Secret_Agent,
                PermissionLevel = HRManager.Models.Constants.PermissionLevel.Low

            };
            Employee Lots_of_Cheese = new Employee()
            {
                   FirstName = "ut",
                   LastName = "jfjdhfyryfghfhgghfggf"

            };
            Employee _3rd_employee= new Employee()
            {
                FirstName = "Rylegh", 
                LastName = "Murphy",
                Address = "912 E 2600 N",
                       Manager = new Employee ()
                       {
                           FirstName = "Mark",
                           LastName = "Murphy"
                       }

            };
            Employee _4th_employee = new Employee()
            {
                FirstName = "Via",
                LastName = "Armstrong",
                FavoriteColor = "red",
            };
            List<Employee> pointer = new List<Employee>()
            { _2ndEmployee, employee, Lots_of_Cheese, _3rd_employee, _4th_employee };
            HRManager.Models.ViewModels.List_Employee_ViewModel
                tester_view_model = new List_Employee_ViewModel();
            tester_view_model.Employee_List = pointer;

              return View(tester_view_model);
        }
        public IActionResult IndividualTeamMember()
        {
            Employee individual = new Employee()
            {
                EmployeeId = 1,
                FirstName = "Ryan",
                LastName = "Armstrong",
                Address = "837 E 2600 N North Ogden, UT 84414",
                Email = "ryscottarmstrong@gmail.com",
                PhoneNumber = "801-900-5981",
                Position = "Software Developer",
                Department = HRManager.Models.Constants.Department.Information_Technology,
                StartDate = new DateTime(2017, 04, 03),
                EndDate = new DateTime(),
                EmploymentStatus = HRManager.Models.Constants.Employment_Status.Owner,
                Shift = HRManager.Models.Constants.Shift.Day,
                Manager = new Employee()
                {
                    FirstName = "Heavenly",
                    LastName = "Father",
                },
                ////Team Member Photo (above my skill level at present)
                FavoriteColor = "I like colors",
                PermissionLevel = HRManager.Models.Constants.PermissionLevel.Low,
                UserName = "RyScott",
                PassWord = "Uint%43K8"
            };
            return View(individual);
        }
        public IActionResult CreateRecord()
        {
            return View();
        }
    }
}
