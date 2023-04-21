using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories
{
    public class UserRepo
    {
        private readonly ShopContext _context;

        public async Task<User> GetUserById(Guid id)
        {
            return await Task.FromResult(_context.Users.FindAsync(id).Result);
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await Task.FromResult(await _context.Users.FirstOrDefaultAsync(u => u.Email == email));
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await Task.FromResult(_context.Users.ToList());
        }


        public async Task<bool> UpdateUser(User user)
        {
            var removal = await DeleteUser(user.Id);
            if (!removal)
                return false;
            await _context.Users.AddAsync(user);
            var task = await _context.SaveChangesAsync();
            return task > 0;
        }

        public async Task<bool> DeleteUser(Guid Id)
        {
            var userToDelete = await GetUserById(Id);
            if (userToDelete == null)
            {
                return false;
            }
            _context.Users.Remove(userToDelete);
            return await _context.SaveChangesAsync() > 0;
        }


        public async Task<bool> UserExists(Guid id)
        {
            return await Task.FromResult(_context.Users.Any(u => u.Id == id));
        }

        public async Task<bool> CreateUser(User user)
        {
            await _context.Users.AddAsync(user);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
