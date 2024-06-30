using APITest.Model;
using Microsoft.AspNetCore.Mvc;

namespace APITest.Infrastructure
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ConnectionContext _connectionContext = new();

        /*public EmployeeRepository(ConnectionContext connectionContext)
        {
            _connectionContext = connectionContext;
        }*/

        public void Add(Employee employee)
        {
            _connectionContext.Employees.Add(employee);
            _connectionContext.SaveChanges();
        }

        public List<Employee> Get()
        {
            return _connectionContext.Employees.ToList();
        }

        public Employee? GetEmployee(int id)
        {
            return _connectionContext.Employees.Find(id);
        }
    }
}
