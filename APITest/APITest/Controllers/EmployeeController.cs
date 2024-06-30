using APITest.Model;
using APITest.Model.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APITest.Controllers
{
    [ApiController]
    [Route("api/v1/Employee")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [Authorize]
        [HttpPost]
        public IActionResult Add([FromForm] EmployeeViewModel employeeViewModel)
        {
            var filePath = Path.Combine("Storage", employeeViewModel.Photo.FileName);
            using (Stream filestream = new FileStream(filePath, FileMode.Create))
            {
                employeeViewModel.Photo.CopyTo(filestream);
            }
                var employee = new Employee(employeeViewModel.Name, employeeViewModel.Age, filePath);
            _employeeRepository.Add(employee);
            return Ok();
        }

        [Authorize]
        [HttpPost]
        [Route("{id}/download")]
        public IActionResult DownloadPhoto(int id)
        {
            var employee = _employeeRepository.GetEmployee(id);
            var databyte = System.IO.File.ReadAllBytes(employee.Photo);
            return File(databyte, "image/png");
        }

        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            var a = _employeeRepository.Get();
            return Ok(a);
        }
    }
}
