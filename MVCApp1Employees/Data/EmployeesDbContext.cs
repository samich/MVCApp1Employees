using Microsoft.EntityFrameworkCore;
using MVCApp1Employees.Models;

namespace MVCApp1Employees.Data
{
    public class EmployeesDbContext : DbContext
    {

        public EmployeesDbContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
