using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Schema;

namespace Data.Entities.Models
{
    public class SubCategory
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
        public string Description { get; set; }

        public Guid CategoryId;
        public Category? Category;

        public JSchema Schema { get; set; } = new();

    }
}
