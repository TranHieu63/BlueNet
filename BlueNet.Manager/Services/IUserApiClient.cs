using BlueNet.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlueNet.Manager.Services
{
    public interface IUserApiClient
    {
        Task<List<UserDto>> GetUsers(UserSearch userSearch);

        Task<UserDto> GetUserDetail(string id);

        Task<bool> CreateUser(UserCreateRequest request);
        Task<UserDto> GetUserByUserName(string userName);

        Task<bool> UpdateUser(Guid id, UserUpdateRequest request);

        Task<bool> DeleteUser(Guid id);


    }
}
