using BlueNet.Api.Data;
using BlueNet.Api.Entities;
using BlueNet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlueNet.Api.Repositoties
{
    public class UserRepository : IUserRepository
    {

        private readonly BlueNetDbContext _context;

        public UserRepository(BlueNetDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get User List
        /// </summary>
        /// <returns></returns>
        public async Task<List<User>> GetUserList()
        {
            return await _context.Users.ToListAsync();
        }

        /// <summary>
        /// Get By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<User> GetById(Guid id)
        {
            return await _context.Users.FindAsync(id);
        }

        /// <summary>
        /// Create User
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<User> Create(User user)
        {
            var _passwordHasher = new PasswordHasher<User>();
            user.PasswordHash = _passwordHasher.HashPassword(user, user.PasswordHash);

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        /// <summary>
        /// Update User
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<User> Update(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return user;
        }

        /// <summary>
        /// Delete User
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<User> Delete(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return user;
        }

        /// <summary>
        /// Get By UserName
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public async Task<User> GetByUserName(string userName)
        {
            User user = null;
            var listUser = await _context.Users.ToListAsync();
            foreach (var item in listUser)
            {
                if(userName == item.UserName)
                {
                    user = item;
                }
            }
            return user ;
        }

        /// <summary>
        /// Lấy danh sách Role
        /// </summary>
        /// <returns></returns>
        /// 2022/06/14
        public async Task<List<Role>> GetRole()
        {
            return await _context.Roles.ToListAsync();
        }

        /// <summary>
        /// Get User Role
        /// </summary>
        /// <returns></returns>
        public async Task<List<IdentityUserRole<Guid>>> GetUserRole()
        {
            return await _context.UserRoles.ToListAsync();
        }

        /// <summary>
        /// Create User Role
        /// </summary>
        /// <param name="userRole"></param>
        /// <returns></returns>
        public async Task<int> CreateUserRole(UserRole userRole)
        {
            
            await _context.UserRoles.AddAsync(userRole);
            return await _context.SaveChangesAsync();
        }
    }
}
