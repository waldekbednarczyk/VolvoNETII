using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using VolvoNETII.DataAccess.Models;
using VolvoNETII.DataAccess.Repositories;

namespace VolvoNETII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeesController( IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        // GET api/employees
        //GET all employees
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            List<Employee> employees;
            employees = _employeeRepository.GetAll().ToList();
            return Ok(employees);
        }

        // GET api/employees/ID
        //GET employee by id
        [HttpGet("byid/{id}")]
        public ActionResult<string> Get(int id)
        {
            Employee employee;
            employee = _employeeRepository.FindBy(p => p.EmployeeId == id).SingleOrDefault();
            return Ok(employee);
        }

        // GET api/employees/ID
        //GET employees by Name
        [HttpGet("byname/{name}")]
        public ActionResult<string> Get(string name)
        {
            List<Employee> employees;
            employees = _employeeRepository.FindBy(p => p.FirstName == name).ToList();
            return Ok(employees);
        }

        // PUT api/employees/ID
        //Edit FirstName by ID
        [HttpPut("{id}")]
        public ActionResult Put(int id, string value)
        {
            Employee employee = _employeeRepository.FindBy(p => p.EmployeeId == id).Single();
            employee.FirstName = value;
            _employeeRepository.Edit(employee);
            return RedirectToAction("Get");
        }

        // DELETE api/employees/ID
        // DELETE employee by ID
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Employee employee;
            employee = _employeeRepository.FindBy(p => p.EmployeeId == id).SingleOrDefault();
            if (employee == null) return BadRequest();
            _employeeRepository.Delete(employee);
            return RedirectToAction("Get");
        }
    }
}
