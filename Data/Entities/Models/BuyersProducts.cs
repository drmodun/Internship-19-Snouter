using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities.Models
{
    public class BuyersProducts
    {
        public Guid BuyerId { get; set; }
        public Guid ProductId { get; set; }

        public Product Product { get; set; }
        public User Buyer { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
