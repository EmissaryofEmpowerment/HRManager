using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HRManager.Models;
using System.Diagnostics;

namespace HRManager.Controllers
{
    public class StatisticsController : Controller
    {
        public IActionResult Statistics()
        {
            DateTime FireHireDate = new DateTime(2014, 02, 12);
            Statistics stats = new Statistics(FireHireDate);
            stats.CalculateVeteranTeamMembers();
            stats.CalculateWeeklyHires();
            stats.CalculateYearlyTerminations();
            return View(stats);
        }
    }
}