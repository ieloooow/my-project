using ASPNETCoreApplication.Model;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreApplication.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
            
        }

        public DbSet<EmployeesModel> Employees2 { get; set; }

    }
}
