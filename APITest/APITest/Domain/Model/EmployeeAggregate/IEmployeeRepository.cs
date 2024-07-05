using APITest.Domain.DTOs;

namespace APITest.Domain.Model.EmployeeAggregate
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);

        List<EmployeeDTO> Get(int pageNumber, int pageQuantity);
        Employee? GetEmployee(int id);
    }
}
