using APITest2.Domain.DTOs;
using System.Collections.Generic;
using System.Linq;
using APITest2.Domain.Model.EmployeeAggregate;

namespace APITest2.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ConnectionContext _connectionContext = new ConnectionContext();
        public void Add(Employee employee)
        {
            _connectionContext.Add(employee);
            _connectionContext.SaveChanges();
        }

        public List<EmployeeDTO> Get(int pageNumber, int pageQuantity)
        {
            return _connectionContext.Employees.Skip(pageNumber * pageQuantity)
                .Take(pageQuantity)
                .Select(employee => 
                new EmployeeDTO() 
                { 
                    Id = employee.Id, 
                    EmployeeName = employee.Name, 
                    Photo = employee.Photo 
                })
                .ToList();
        }

        public Employee Get(int id)
        {
            return _connectionContext.Employees.Find(id);
        }
    }
}
