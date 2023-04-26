using Domain.DTO;

namespace Domain.Contracts.Response.User
{
    public class GetAllUsersResponse
    {
        public List<ViewProfile>? Users { get; set; }
    }
}
