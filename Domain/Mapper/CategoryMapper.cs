using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Entities.Models;
using Domain.DTO;

namespace Domain.Mapper
{
    public  class CategoryMapper
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
                Schema = category.Schema.ToString(),
                SubCategories = _shopContext.SubCategories.Where(sb=>sb.CategoryId == category.Id).Select(c=>c.Id).ToList(),
                Products = _shopContext.Products.Where(p=>p.CategoryId == category.Id).Select(p=>p.Id).ToList()
            };
            return newDTO;
        }

        public  SubCategoryDTO SubCategoryToDTO(SubCategory subCategory)
        {
            var newDTO = new SubCategoryDTO
            {
                Id = subCategory.Id,
                Name = subCategory.Name,
                Description = subCategory.Description,
                Schema = subCategory.Schema.ToString(),
                Category = subCategory.CategoryId,
                Products = _shopContext.Products.Where(p => p.CategoryId == subCategory.Id).Select(p => p.Id).ToList()
            };
            return newDTO;
        }
    }
}
