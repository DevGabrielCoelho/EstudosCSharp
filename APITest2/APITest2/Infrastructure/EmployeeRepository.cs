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

        public List<Employee> Get()
        {
            return _connectionContext.Employees.ToList();
        }

        public Employee? Get(int id)
        {
            return _connectionContext.Employees.Find(id);
        }
    }
}
