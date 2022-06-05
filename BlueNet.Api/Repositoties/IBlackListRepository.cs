using BlueNet.Api.Entities;
using BlueNet.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlueNet.Api.Repositoties
{
    public interface IBlackListRepository
    {
        Task<IEnumerable<BlackList>> GetBlackList(BlackListSearch blackListSearch);

        Task<IEnumerable<BlackList>> GetBlackListByUserId(Guid userId, BlackListSearch blackListSearch);

        Task<BlackList> Create(BlackList blackList);

        Task<BlackList> Update(BlackList blackList);

        Task<BlackList> Delete(BlackList blackList);

        Task<BlackList> GetById(Guid id);

        Task<bool> CheckUrl(CheckUrlParameter checkUrl);
    }
}
