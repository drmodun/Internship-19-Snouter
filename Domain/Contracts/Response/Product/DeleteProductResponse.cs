using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Response.Product
{
    public class DeleteProductResponse
    {
        public bool Success { get; set; }
        public HttpStatusCode Status { get; set; }
    }
}
