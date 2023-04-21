using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Response.BuyersProducts
{
    public class UpdateBuyersProductsResponse
    {
        public BuyersProductsView? BuyersProducts;
        public bool Success;
        public HttpStatusCode Status;
    }
}
