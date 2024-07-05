using APITest.Domain.DTOs;
using APITest.Domain.Model.EmployeeAggregate;
using Microsoft.AspNetCore.Mvc;

namespace APITest.Infrastructure.Repositories
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

        public List<EmployeeDTO> Get(int pageNumber, int pageQuantity)
        {
            return _connectionContext.Employees.Skip(pageNumber * pageQuantity).Take(pageQuantity).Select(x => new EmployeeDTO() { Id = x.Id, NameEmployee = x.Name, Photo = x.Photo}).ToList();
        }

        public Employee? GetEmployee(int id)
        {
            return _connectionContext.Employees.Find(id);
        }
    }
}
