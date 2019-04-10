using System;
using System.Collections.Generic;
using System.Text;
using VolvoNETII.DataAccess.Repositories;
using VolvoNETII.DataAccess.Models;
using VolvoNETII.Core.DataAccessService.DTO;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VolvoNETII.Core.DataAccessService
{
    public class SampleService1 : ISampleService1
    {
        private IGenericRepository<Employee> _employeeRepository;
        
        public SampleService1(IGenericRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<EmployeeDTO> GetEmployee(string name)
        {
            var employee = await _employeeRepository.FindBy(x => x.FirstName == name).FirstOrDefaultAsync();

            return new EmployeeDTO
            {
                Name = employee.FirstName,
                Surname = employee.LastName
            };
        }
    }
}
