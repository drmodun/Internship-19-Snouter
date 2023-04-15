using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities.Models
{
    public class Product : IProduct
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Guid Seller { get; set; }
        public List<string> Images { get; set; }
        public string Category { get; set; }
        public List<string> Tags { get; set; }
    }
}
