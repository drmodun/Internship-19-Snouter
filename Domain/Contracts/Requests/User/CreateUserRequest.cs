namespace Domain.Contracts.Requests.User
{
    public class CreateUserRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Guid LocationId { get; set; }

    }
}
