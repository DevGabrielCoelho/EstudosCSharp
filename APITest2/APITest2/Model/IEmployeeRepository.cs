namespace APITest2.Model
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);

        List<Employee> Get(); 

        Employee? Get(int id);
    }
}
