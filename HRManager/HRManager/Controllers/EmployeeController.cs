using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRManager.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace HRManager.Controllers
{
    public class EmployeeController: Controller
    {
        public IActionResult AllEmployees()
        {

            Employee employee = new Employee()
            {
                FirstName = "Ryan",
                LastName = "Armstrong",
                Address = "837 E 2600 N North Ogden, UT 84414",
                Email = "ryscottarmstrong@gmail.com",
                PhoneNumber = "801-900-5981",
                Position = "Software Developer",
                // How do I instantiate a Dictionary variable?
                Department = new HRManager.Models.Constants.Department(),
                StartDate = new DateTime(2017, 04, 03),
                EndDate = new DateTime(),
                EmploymentStatus = "Owner",
                Shift = "Day",
                   Manager = new Employee()
                   {
                       FirstName = "Heavenly",
                       LastName = "Father",
                   },
                ////Team Member Photo (above my skill level at present)
                FavoriteColor = "I like colors"
            };
            return View(employee);
        }
    }
}
