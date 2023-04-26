using Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories.Interfaces
{
    public interface IUserRepo
    {
        public Task<User> GetUserById(Guid id, CancellationToken cancellationToken = default);
        public Task<List<User>> GetAllUsers();
        public Task<bool> CreateUser(User User, CancellationToken cancellationToken = default);
        public Task<bool> UpdateUser(User User, CancellationToken cancellationToken = default);
        public Task<bool> DeleteUser(Guid id, CancellationToken cancellationToken = default);


    }
}
