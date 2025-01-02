using Microsoft.EntityFrameworkCore;

namespace Employee.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employer> Employees { get; set; }
    }
}
