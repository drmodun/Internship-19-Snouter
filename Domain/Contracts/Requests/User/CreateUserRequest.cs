using Data.Entities.Models;

namespace Domain.Contracts.Requests.User
{
    public class CreateUserRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public Guid LocationId { get; set; }

    }
}
