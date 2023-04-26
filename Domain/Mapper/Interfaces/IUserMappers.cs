using Data.Entities.Models;
using Domain.DTO;

namespace Domain.Mapper.Interfaces
{
    public interface IUserMappers
    {
        public ViewProfile MapUserToDTO(User userToMap);




    }
}
