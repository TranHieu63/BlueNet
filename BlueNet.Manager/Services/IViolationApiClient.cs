using BlueNet.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlueNet.Manager.Services
{
    public interface IViolationApiClient
    {
        //Lấy danh sách vi phạm Violation
        Task<List<ViolationParameter>> GetViolations();
    }
}
