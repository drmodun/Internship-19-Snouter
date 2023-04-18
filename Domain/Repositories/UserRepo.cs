using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Entities.Models;

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
            return await Task.FromResult(_context.Users.FirstOrDefault(u => u.Email == email));
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await Task.FromResult(_context.Users.ToList());
        }

        public async Task<User> AddUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> UpdateUser(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> DeleteUser(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> DeleteUserById(Guid id)
        {
            var user = await GetUserById(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<bool> UserExists(Guid id)
        {
            return await Task.FromResult(_context.Users.Any(u => u.Id == id));
        }
    }
}
