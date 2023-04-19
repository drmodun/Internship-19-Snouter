namespace Domain.Contracts.Requests.User
{
    public class UserRequest
    {
        public Guid Id { get; set; }
        public string Slug { get; set; }
    }
}
