using Factory_Design.Models;
using Microsoft.EntityFrameworkCore;

namespace Factory_Design.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)

            : base(options)

        {



        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<EmployeeType> EmployeeTypes { get; set; }



    }
    
}
