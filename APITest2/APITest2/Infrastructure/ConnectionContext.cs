using APITest2.Domain.Model.EmployeeAggregate;
using Microsoft.EntityFrameworkCore;

namespace APITest2.Infrastructure
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseMySQL("server=localhost;port=3306;userid=developer;password=123qwer;database=apitest2appdb;");
    }
}
