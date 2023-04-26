using Data.Entities;
using Data.Entities.Models;
using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories
{
    public class UserRepo : IUserRepo
    {
        private readonly ShopContext _context = new ShopContextFactory().CreateDbContext(null);
        public UserRepo(ShopContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserById(Guid id, CancellationToken cancellationToken = default)
        {
            return await Task.FromResult(await _context.Users.FindAsync(id, cancellationToken));
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await Task.FromResult(await _context.Users.FirstOrDefaultAsync(u => u.Email == email));
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await Task.FromResult(_context.Users.ToList());
        }


        public async Task<bool> UpdateUser(User user, CancellationToken cancellationToken = default)
        {

            var userToDelete = await GetUserById(user.Id);
            if (userToDelete == null)
                return false;
            _context.Users.Remove(userToDelete);
            return await CreateUser(user, cancellationToken);


        }

        public async Task<bool> DeleteUser(Guid Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var userToDelete = await GetUserById(Id);
                if (userToDelete == null)
                {
                    return false;
                }
                _context.Users.Remove(userToDelete);
                return await _context.SaveChangesAsync(cancellationToken) > 0;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }


        public async Task<bool> UserExists(Guid id, CancellationToken cancellationToken = default)
        {
            return await Task.FromResult(_context.Users.Any(u => u.Id == id));
        }

        public async Task<bool> CreateUser(User user, CancellationToken cancellationToken = default)
        {
            try
            {
                await _context.Users.AddAsync(user);
                return await _context.SaveChangesAsync(cancellationToken) > 0;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }
    }
}
