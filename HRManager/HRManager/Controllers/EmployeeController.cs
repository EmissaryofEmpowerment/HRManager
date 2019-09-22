using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRManager.Models;
using System.Web;
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
                //Department = <1, "Software Development"
                // DateTime StartDate { get; set; }
                // DateTime EndDate { get; set; }
                // Dictionary<int, string> EmploymentStatus { get; set; }
                // Dictionary<int, string> Shift { get; set; }
                // Employee Manager { get; set; }
                ////Team Member Photo (above my skill level at present)
                FavoriteColor = "I like colors"
            };
            return View();
        }
    }
}
