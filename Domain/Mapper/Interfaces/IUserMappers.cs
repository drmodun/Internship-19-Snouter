using Data.Entities.Models;
using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mapper.Interfaces
{
    public interface IUserMappers 
    {
        public ViewProfile MapUserToDTO(User userToMap);




    }
}
