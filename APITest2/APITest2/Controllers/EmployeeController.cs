using APITest2.Model;
using APITest2.Model.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APITest2.Controllers
{
    [ApiController]
    [Route("api/v1/Employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(IEmployeeRepository employeeRepository, ILogger<EmployeeController> logger)
        {
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpPost]
        public IActionResult Add([FromForm]EmployeeViewModel employeeViewModel)
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
            List<Employee> list = _employeeRepository.Get(pageNumber, pageQuantity);
            return Ok(list);
        }

        [HttpPost]
        [Route("{id}/download")]
        public IActionResult DownloadPhoto(int id)
        {
            Employee employee = _employeeRepository.Get(id);
            byte[] dataBytes = System.IO.File.ReadAllBytes(employee.Photo);
            return File(dataBytes, "image/png");
        }
    }
}
