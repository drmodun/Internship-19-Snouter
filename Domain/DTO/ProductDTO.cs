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
        public List<Blob> Images { get; set; }
        public CategoryDTO Category { get; set; }
        public SubCategoryDTO SubCategory { get; set; }
        public ViewProfile Seller { get; set; }

        public List<BuyersProductsView> BuyersProducts { get; set; }
        public decimal Price { get; set; }
        public DateTime Created { get; set; }
        public int Quantity { get; set; }

        public LocationView Location;
        public string UpdatedAt { get; set; }

        public string ExtraProperties;
        public string SubProperties { get; set; }
    }
}
