using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities.Models;
using Newtonsoft.Json.Schema;

namespace Domain.DTO
{
    public class CategoryDTO
    {
        public Guid Id;
        public string Name;
        public string Description;
        public string Schema;
        public List<ProductDTO> Products;
        public List<SubCategoryDTO> SubCategories;
    }
}
