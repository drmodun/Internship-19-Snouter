namespace Domain.Contracts.Requests.User
{
    public class DeleteUserRequest
    {
        public Guid Id { get; set; }
        public string Slug { get; set; }
    }
}
