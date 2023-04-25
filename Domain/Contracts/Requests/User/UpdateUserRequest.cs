using System.Globalization;

namespace Domain.Contracts.Requests.User
{
    public class UpdateUserRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Guid LocationId { get; set; }

    }
}
