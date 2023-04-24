using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Data.Entities.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace Domain.DTO
{
    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Images { get; set; }
        public Guid Category { get; set; } 
        public Guid SubCategory { get; set; }
        public Guid Seller { get; set; }

        public List<Guid> BuyersProducts { get; set; } = new List<Guid>();
        public decimal Price { get; set; }
        public DateTime Created { get; set; } 
        public int Quantity { get; set; } 

        public Guid Location { get; set; }

        public string ExtraProperties { get; set; }
        public string SubProperties { get; set; }
    }
}
