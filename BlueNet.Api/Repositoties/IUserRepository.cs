using BlueNet.Api.Entities;
using BlueNet.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlueNet.Api.Repositoties
{
    public interface IUserRepository
    {
        Task<List<User>> GetUserList();
        Task<User> GetById(Guid id);
        Task<User> Create(User user);
        Task<User> Update(User user);
        Task<User> Delete(User user);
    }
}
