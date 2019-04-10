using System;
using System.Collections.Generic;
using System.Text;
using VolvoNETII.DataAccess.Context;
using VolvoNETII.DataAccess.Models;

namespace VolvoNETII.DataAccess.Repositories
{
    public class JobRepository : GenericRepository<ApplicationDbContext, Job>, IJobRepository
    {
        public JobRepository(ApplicationDbContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
