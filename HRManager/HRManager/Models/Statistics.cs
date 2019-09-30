using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManager.Models
{
    public class Statistics
    {
        public int WeeklyHireNumbers { get; set; }
        public int YearlyTerminations { get; set; }
        public int VeteranTeamMembers { get; set; }
        public DateTime HireFireDate;
        public DateTime today = DateTime.Now;

        public Statistics(DateTime _HireFireDate)
        {
            HireFireDate = _HireFireDate;
        }

        public void CalculateWeeklyHires()
        {
            int delta = DayOfWeek.Monday - today.DayOfWeek;
            if (delta > 0)
            {
                delta -= 7;
            }
            DateTime MostRecentMonday = today.AddDays(delta);
            if (HireFireDate < MostRecentMonday)
            {
                WeeklyHireNumbers++;
            }
        }

        public void CalculateYearlyTerminations()
        {
            if (HireFireDate.Year == today.Year)
            {
                YearlyTerminations++;
            }
        }

        public void CalculateVeteranTeamMembers()
        {
            if (HireFireDate.Year <= today.Year - 4)
            {
                VeteranTeamMembers++;
            }
        }

    }
}
