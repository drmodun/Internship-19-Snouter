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
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
        public string Description { get; set; }

        public int CategoryId;
        public Category? Category;
        public Dictionary<string, object> SubProperties { get; set; } = new();

        public JSchema Schema { get; set; } = new();

    }
}
