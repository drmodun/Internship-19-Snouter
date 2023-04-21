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
        public Guid Id;
        public string Slug;
        public string Name;

        public string Description;

        public Guid SellerId;

        public Guid LocationId;

        public Guid CategoryId;
        public Guid SubCategoryId;
        public string ExtraProperties;
        public string SubProperties;
        public List<string> Images;
        public List<(Guid, Guid)> Buyers;
        public int Quantity;

    }
}
