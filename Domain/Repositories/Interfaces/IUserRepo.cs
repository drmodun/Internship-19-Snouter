using Data.Entities.Models;

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
