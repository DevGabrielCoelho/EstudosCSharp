using APITest.Model;
using Microsoft.EntityFrameworkCore;

namespace APITest.Infrastructure
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySQL("server=localhost;userid=developer;password=123qwer;database=apitestappdb");
    }
}
