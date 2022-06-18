using BlueNet.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlueNet.Manager.Services
{
    public interface IBlackListApiClient
    {
        Task<List<BlackListDto>> GetBlackList(BlackListSearch blackListSearch);
        Task<List<BlackListDto>> GetMyBlackList(BlackListSearch blackListSearch);

        //Task<PagedList<BlackListDto>> GetBlackList(BlackListSearch blackListSearch);
        Task<BlackListDto> GetBlackListDetail(string id);

        Task<object> CreateBlackList(BlackListCreateRequest request);

        Task<bool> UpdateBlackList(Guid id, BlackListUpdateRequest request);

        Task<bool> DeleteBlackList(Guid id);
    }
}
