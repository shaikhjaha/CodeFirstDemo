using CodeFirstDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstDemo.Entities
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options)
        {
        }
        public virtual DbSet<EmployeeMaster> EmployeeMasters { get; set; }
    }
}
