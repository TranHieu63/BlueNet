using BlueNet.Api.Data;
using BlueNet.Api.Entities;
using BlueNet.Models;
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

        public async Task<List<User>> GetUserList()
        {
            return await _context.Users.ToListAsync();
        }

        //GetById
        public async Task<User> GetById(Guid id)
        {
            return await _context.Users.FindAsync(id);
        }

        //Create
        public async Task<User> Create(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        //Update
        public async Task<User> Update(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return user;
        }

        //Delete
        public async Task<User> Delete(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
