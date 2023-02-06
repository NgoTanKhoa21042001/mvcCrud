using Microsoft.EntityFrameworkCore;
using mvcCrud.Models.Domain;

namespace mvcCrud.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options) { 
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
