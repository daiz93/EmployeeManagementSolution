

using BaseLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace Server.Data
{
    public class AppDbContext4 (DbContextOptions<AppDbContext4> options):DbContext(options)
    {
        
        public DbSet<Employee> Employees { get; set; }
        public DbSet<GeneralDepartment> GeneralDepartments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Branch> Branches { get; set; }

        public DbSet<Town> Towns { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }    


    }
}
