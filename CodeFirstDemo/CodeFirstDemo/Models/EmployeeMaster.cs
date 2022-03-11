using System;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstDemo.Models
{
    public class EmployeeMaster
    {
        [Key]
        public int Id { get; set; }
        public string EmpName { get; set; }
        public DateTime DOB { get; set; }
        public string MobileNumber { get; set; }
        public decimal Salary { get; set; }
    }
}
