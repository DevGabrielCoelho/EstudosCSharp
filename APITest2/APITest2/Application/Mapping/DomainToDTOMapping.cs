using APITest2.Domain.DTOs;
using APITest2.Domain.Model.EmployeeAggregate;
using AutoMapper;

namespace APITest2.Application.Mapping
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping() 
        {
            CreateMap<Employee, EmployeeDTO>()
                .ForMember(employeeDTO=> employeeDTO.EmployeeName, mapping => mapping.MapFrom(employee => employee.Name));
        }
    }
}
