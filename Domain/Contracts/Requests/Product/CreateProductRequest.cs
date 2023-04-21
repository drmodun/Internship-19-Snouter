using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace Domain.Contracts.Requests.Product
{
    public class CreateProductRequest
    {
        public string Name;

        public string Description;

        public int Quantity;

        public Guid SellerId;

        public Guid LocationId;

        public Guid CategoryId;
        public Guid SubCategoryId;
        public string ExtraProperties;
        public string SubProperties;
        public List<string> Images;
    }
}
