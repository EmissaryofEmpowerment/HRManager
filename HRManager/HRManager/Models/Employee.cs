using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using AspNetCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRManager.Models
{
    public class Employee
    {
        public Employee()
        {
           
        }
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage ="This field is required")]
        [DisplayName("Employee Number")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Position { get; set; }
        public HRManager.Models.Constants.Department Department { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public HRManager.Models.Constants.Employment_Status EmploymentStatus { get; set; }
        public HRManager.Models.Constants.Shift Shift { get; set; }
        public Employee Manager { get; set; }
        //Team Member Photo (above my skill level at present)
        public string FavoriteColor { get; set; }
        public HRManager.Models.Constants.PermissionLevel PermissionLevel { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public List<Employee> Employee_List { get; set; }
    }
}

