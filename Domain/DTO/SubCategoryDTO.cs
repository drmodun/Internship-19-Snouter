using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Schema;

namespace Domain.DTO
{
    public class SubCategoryDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Guid Category { get; set; }

        public List<Guid> Products { get; set; } = new List<Guid>();

        public string Schema { get; set; }


    }
}
