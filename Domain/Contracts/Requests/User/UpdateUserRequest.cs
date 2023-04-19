using System.Globalization;

namespace Domain.Contracts.Requests.User
{
    public class UpdateUserRequest
    {
        public Guid Id { get; set; }
        public string Name;
        public string Password;
        public string Email;
        public bool isAdmin;
        public ICollection<Guid> Products;
        public ICollection<Guid> BoughtProducts;

    }
}
