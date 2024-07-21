using Microsoft.EntityFrameworkCore;

namespace DeptHieracy.Models
{
    public class DepartmentContext : DbContext
    {
        public DbSet<Dept> Depts { get; set; }
        public DepartmentContext() : base()
        {

        }
        public DepartmentContext(DbContextOptions<DepartmentContext> options) : base(options) { }
    }
}
