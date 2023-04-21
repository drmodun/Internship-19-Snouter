using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Domain.DTO;

namespace Domain.Contracts.Response.User
{
    public class UpdateUserResponse
    {
        public bool Success { get; set; }
        public ViewProfile? User { get; set; }
        public HttpStatusCode Status { get; set; }
    }
}
