using BlueNet.Api.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlueNet.Api.Repositoties
{
    public interface IViolationRepository
    {
        Task<List<Violation>> GetViolationList();

       //Task<bool> SaveViolation();
    }
}
