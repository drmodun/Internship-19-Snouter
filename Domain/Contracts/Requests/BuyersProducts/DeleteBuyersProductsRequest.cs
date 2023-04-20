using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Requests.BuyersProducts
{
    public class DeleteBuyersProductsRequest
    {
        public Guid ProductId;
        public Guid UserId;
    }
}
