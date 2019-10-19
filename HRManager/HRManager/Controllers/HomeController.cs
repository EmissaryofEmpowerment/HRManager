using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HRManager.Models;

namespace HRManager.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "All about our Company:" +
                "We love our Employees!";
            ViewData["Time"] = DateTime.Now.ToString();

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Let's connect, collaborate, confer, and convene!";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?
                .Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login()
        {
            Employee employee = new Employee()
            {
                UserName = "VidaliaPearlArmstrong",
                PassWord = "computergirl"
            };
            return View(employee);
        }
    }
}
