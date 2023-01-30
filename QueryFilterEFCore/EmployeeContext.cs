using Microsoft.EntityFrameworkCore;

namespace QueryFilterEFCore
{
    public partial class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Authors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasQueryFilter(c => c.IsActive);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
           new Employee { Id = 1,Name = "Jay", Age = 27, ContactNo = 99999999, IsActive = true },
            new Employee { Id = 2,Name ="Krishna", Age=26, ContactNo=88888888, IsActive = true },
            new Employee { Id = 3,Name ="Reddy", Age=25, ContactNo=88888888, IsActive = false },
            new Employee { Id = 4,Name ="Majji", Age=26, ContactNo=77777777, IsActive = false }
            );
        }
    }
}
