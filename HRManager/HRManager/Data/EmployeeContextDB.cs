using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace HRManager.Data
{
    public class EmployeeContextDB: DbContext
    {
        public EmployeeContextDB(DbContextOptions<EmployeeContextDB> options):base(options)
        {

        }

        public DbSet<HRManager.Models.Employee>
            Employees { get; set; }
    }
}
