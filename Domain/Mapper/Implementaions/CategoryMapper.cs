using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Data.Entities;
using Data.Entities.Models;
using Domain.DTO;
using Domain.Mapper.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;

namespace Domain.Mapper.Implementaions
{
    public class CategoryMapper : ICategoryMapper
    {
        private readonly ShopContext _shopContext;

        public CategoryMapper(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }
        public CategoryDTO CategoryToDTO(Category category)
        {
            var newDTO = new CategoryDTO
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                Schema = JsonConvert.SerializeObject(category.Schema, Newtonsoft.Json.Formatting.None),
                SubCategories = _shopContext.SubCategories.Where(sb => sb.CategoryId == category.Id).Select(c => c.Id).ToList(),
                Products = _shopContext.Products.Where(p => p.CategoryId == category.Id).Select(p => p.Id).ToList()
            };
            return newDTO;
        }

        public SubCategoryDTO SubCategoryToDTO(SubCategory subCategory)
        {
            var newDTO = new SubCategoryDTO
            {
                Id = subCategory.Id,
                Name = subCategory.Name,
                Description = subCategory.Description,
                Schema = JsonConvert.SerializeObject(subCategory.Schema, Newtonsoft.Json.Formatting.None),
                Category = subCategory.CategoryId,
                Products = _shopContext.Products.Where(p => p.CategoryId == subCategory.Id).Select(p => p.Id).ToList()
            };
            return newDTO;
        }
    }
}
