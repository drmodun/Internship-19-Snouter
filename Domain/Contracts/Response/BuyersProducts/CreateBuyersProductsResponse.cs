using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Response.BuyersProducts
{
    public class CreateBuyersProductsResponse
    {
        public BuyersProductsView BuyersProducts { get; set; }
        public bool Success { get; set; }
        public HttpStatusCode Status { get; set; }
    }
}
