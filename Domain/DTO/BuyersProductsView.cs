using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class BuyersProductsView
    {
        public Guid Buyer { get; set; }
        public Guid Product { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
