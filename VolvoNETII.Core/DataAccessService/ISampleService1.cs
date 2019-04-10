using System.Threading.Tasks;
using VolvoNETII.Core.DataAccessService.DTO;

namespace VolvoNETII.Core.DataAccessService
{
    public interface ISampleService1
    {
        Task<EmployeeDTO> GetEmployee(string name);
    }
}