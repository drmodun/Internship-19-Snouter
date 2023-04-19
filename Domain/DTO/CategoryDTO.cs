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
        public int Id;
        public string Name;
        public string Description;
        public JSchema Schema;
        public List<ProductDTO> Products;
        public List<SubCategoryDTO> SubCategories;
    }
}
