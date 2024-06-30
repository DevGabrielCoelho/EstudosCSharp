namespace APITest.Model
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);

        List<Employee> Get();
        Employee? GetEmployee(int id);
    }
}
