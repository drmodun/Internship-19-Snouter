using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Npgsql.EntityFrameworkCore.PostgreSQL.Query.Expressions.Internal;

namespace Data.Entities.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Guid SellerId{ get; set; }

        public DateTime Created { get; set; }
        public User? Seller { get; set; }

        public Guid BuyerId { get; set; }
        public User Buyer { get; set; }

        public List<Blob> Images { get; set; }
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }
        public Guid SubCategoryId { get; set; }
        public SubCategory? SubCategory { get; set; }

        public JObject? ExtraProperties { get; set; }

        public JObject SubProperties { get; set; }
        public ICollection<BuyersProducts> Buyers { get; set; }

        public Guid LocationId;

        public Location Location;



    }
}
