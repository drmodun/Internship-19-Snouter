using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class BuyersProductsView
    {
        public ViewProfile Buyer;
        public ProductDTO Product;
        public int Quantity;
        public DateTime CreatedAt;

    }
}
