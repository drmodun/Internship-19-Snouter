using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Domain.DTO;

namespace Domain.Contracts.Response.User
{
    public class CreateUserResponse
    {
        public bool ? Success { get; set; }
        public ViewProfile? Profile { get; set; }

        public HttpStatusCode StatusCode { get; set; }
    }
}
