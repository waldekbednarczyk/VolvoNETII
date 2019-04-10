using System;
using System.Collections.Generic;
using System.Text;
using VolvoNETII.DataAccess.Context;
using VolvoNETII.DataAccess.Models;

namespace VolvoNETII.DataAccess.Repositories
{
    public class EmployeeRepository : GenericRepository<ApplicationDbContext, Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
