using APITest.Domain.DTOs;
using APITest.Domain.Model.EmployeeAggregate;
using AutoMapper;

namespace APITest.Application.Mapping
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping() 
        {
            CreateMap<Employee, EmployeeDTO>()
                .ForMember(dest => dest.NameEmployee, m => m.MapFrom(orig => orig.Name));
        }
    }
}
