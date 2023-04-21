using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class BuyersProductsView
    {
        public ViewProfile Buyer { get; set; }
        public ProductDTO Product { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
