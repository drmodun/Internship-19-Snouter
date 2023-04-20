using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Requests.BuyersProducts
{
    public class UpdateBuyersProductsRequest
    {
        public Guid ProductId;
        public Guid UserId;
        public int Quantity;
    }
}
