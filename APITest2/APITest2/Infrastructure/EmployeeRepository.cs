using APITest2.Model;

namespace APITest2.Infrastructure
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ConnectionContext _connectionContext = new ConnectionContext();
        public void Add(Employee employee)
        {
            _connectionContext.Add(employee);
            _connectionContext.SaveChanges();
        }

        public List<Employee> Get(int pageNumber, int pageQuantity)
        {
            return _connectionContext.Employees.Skip(pageNumber * pageQuantity).Take(pageQuantity).ToList();
        }

        public Employee? Get(int id)
        {
            return _connectionContext.Employees.Find(id);
        }
    }
}
