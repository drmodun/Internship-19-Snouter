
using System.Security.Cryptography;
using Data.Entities.Models;
using Domain.DTO;

namespace Presentation
{
    public static class Mappers
    {
        public static User RequestToUser(CreateUserRequest request)
        {
            var newUser = new User
            {
                Id = new Guid(),
                Name = request.Name,
                Email = request.Email,
                Password = request.Password,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Address = 
            }
        }
             
    }
}
