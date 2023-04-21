using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Domain.DTO;

namespace Domain.Contracts.Response.User
{
    public class GetUserResponse
    {
        public ViewProfile? User { get; set; }
        public HttpStatusCode Status { get; set; }
        public bool Success { get; set; }
    }
}
