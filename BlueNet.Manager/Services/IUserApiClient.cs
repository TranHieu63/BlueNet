using BlueNet.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlueNet.Manager.Services
{
    public interface IUserApiClient
    {
        //Lấy danh sách user
        Task<List<UserDto>> GetUsers(UserSearch userSearch);

        //Xem danh sách user
        Task<UserDto> GetUserDetail(string id);

        //tìm user theo userName
        Task<UserDto> GetUserByUserName(string userName);

        //Thêm mới user
        Task<bool> CreateUser(UserCreateRequest request);

        //Sửa user
        Task<bool> UpdateUser(Guid id, UserUpdateRequest request);

        //Xóa Delete
        Task<bool> DeleteUser(Guid id);

        //Lấy ra danh sách Role (bảng AspNetRoles)
        //2022.06.14
        Task<List<RoleDto>> GetRole();

        //Lấy ra danh sách AspNetUserRoles
        Task<List<UserRoleDto>> GetUserRole();

    }
}
