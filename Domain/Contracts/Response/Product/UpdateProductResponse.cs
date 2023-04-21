using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Domain.DTO;

namespace Domain.Contracts.Response.Product
{
    public class UpdateProductResponse
    {
        public bool Success { get; set; }
        public HttpStatusCode Status { get; set; }
        public ProductDTO? Product { get; set; }
    }
}
