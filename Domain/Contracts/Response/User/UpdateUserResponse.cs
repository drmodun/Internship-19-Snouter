using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DTO;

namespace Domain.Contracts.Response.User
{
    public class UpdateUserResponse
    {
        public bool Success;
        public ViewProfile User;
        public string Status;
    }
}
}
