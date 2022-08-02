using Employee.API.Model;
using Microsoft.AspNetCore.Mvc;

namespace Employee.API.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeController : Controller
    {
        private readonly EmployeeData _employeeData;
        public EmployeController(EmployeeData employeeData)
        {
            _employeeData = employeeData;
        }

        [HttpGet]
        public ActionResult<IEnumerable<EmployeeViewModel>> GetEmployees()
        {
            return Ok(_employeeData.employeesList);
        }
        [HttpPost]
        public async Task<ActionResult<EmployeeViewModel>> Create(EmployeeViewModel emp)
        {
            _employeeData.employeesList.Add(emp);
            return Ok(_employeeData.employeesList);
        }

        [HttpPut("{id}")]
        public IActionResult EditEmployee(int id, EmployeeViewModel employee)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var employeeresult = _employeeData.employeesList.FirstOrDefault(x => x.Id == id);
            _employeeData.employeesList.Remove(employeeresult);
            employeeresult.FirstName = employee.FirstName;
            employeeresult.LastName = employee.LastName;
            employeeresult.Email = employee.Email;
            employeeresult.MobileNumber = employee.MobileNumber;
            employeeresult.AddressLine1 = employee.AddressLine1;
            employeeresult.AddressLine2 = employee.AddressLine2;
            employeeresult.city = employee.city;
            employeeresult.Country = employee.Country;
            _employeeData.employeesList.Add(employeeresult);
            return Ok(_employeeData.employeesList);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var employeeresult = _employeeData.employeesList.FirstOrDefault(x => x.Id == id);
            _employeeData.employeesList.Remove(employeeresult);
            return Ok(_employeeData.employeesList);
        }
    }
}
