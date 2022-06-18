using BlueNet.Api.Entities;
using BlueNet.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlueNet.Api.Repositoties
{
    public interface IUserRepository
    {
        Task<List<User>> GetUserList();
        //Task<List<User>> GetUserList(UserSearch userSearch);
        Task<User> GetById(Guid id);
        Task<User> Create(User user);
        Task<User> Update(User user);
        Task<User> Delete(User user);
        Task<User> GetByUserName(string userName);
        Task<List<Role>> GetRole();
        Task<List<IdentityUserRole<Guid>>> GetUserRole();
        Task<int> CreateUserRole(UserRole userRole);
    }
}
