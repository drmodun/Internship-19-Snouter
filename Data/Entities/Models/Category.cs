using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Schema;
using Npgsql.PostgresTypes;

namespace Data.Entities.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }

        public JSchema Schema { get; set; } 






    }
}