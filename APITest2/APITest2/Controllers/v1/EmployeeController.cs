using APITest2.Application.ViewModel;
using APITest2.Domain.DTOs;
using APITest2.Domain.Model.EmployeeAggregate;
using Asp.Versioning;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APITest2.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/Employee")]
    [ApiVersion("1.0")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpPost]
        public IActionResult Add([FromForm] EmployeeViewModel employeeViewModel)
        {
            string filePath = Path.Combine("Storage", employeeViewModel.Photo.FileName);

            using Stream fileStream = new FileStream(filePath, FileMode.Create);
            employeeViewModel.Photo.CopyTo(fileStream);

            Employee employee = new Employee() { Name = employeeViewModel.Name, Age = employeeViewModel.Age, Photo = filePath };
            _employeeRepository.Add(employee);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get(int pageNumber, int pageQuantity)
        {
            List<EmployeeDTO> list = _employeeRepository.Get(pageNumber, pageQuantity);
            return Ok(list);
        }

        [HttpGet]
        [ApiExplorerSettings(IgnoreApi = true)]
        [Route("all")]
        public IActionResult Get()
        {
            List<EmployeeDTO> list = _employeeRepository.Get();
            return Ok(list);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Search(int id)
        {
            Employee? employee = _employeeRepository.Get(id);
            EmployeeDTO employeeDTO = _mapper.Map<EmployeeDTO>(employee);
            return Ok(employeeDTO);
        }

        [HttpPost]
        [Route("{id}/download")]
        public IActionResult DownloadPhoto(int id)
        {
            Employee? employee = _employeeRepository.Get(id);
            byte[] dataBytes = System.IO.File.ReadAllBytes(employee.Photo);
            return File(dataBytes, "image/png");
        }
    }
}
