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

        public CategoryDTO Category { get; set; }

        public List<ProductDTO> Products { get; set; }

        public string Schema { get; set; }


    }
}
