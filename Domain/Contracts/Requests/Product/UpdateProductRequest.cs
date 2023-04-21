using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Requests.Product
{
    public class UpdateProductRequest
    {
        public Guid Id { get; set; }
        public string? Slug { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid SellerId { get; set; }

        public Guid LocationId { get; set; }

        public Guid CategoryId { get; set; }
        public Guid SubCategoryId { get; set; }
        public string ExtraProperties { get; set; }
        public string SubProperties { get; set; }
        public List<string> Images { get; set; }
        public List<(Guid, Guid)> Buyers { get; set; }
        public int Quantity { get; set; }

    }
}
