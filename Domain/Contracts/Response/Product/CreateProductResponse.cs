﻿using Domain.DTO;
using System.Net;

namespace Domain.Contracts.Response.Product
{
    public class CreateProductResponse
    {
        public bool Success { get; set; }
        public ProductDTO? Product { get; set; }
        public HttpStatusCode Status { get; set; }
    }
}
