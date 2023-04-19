using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities.Models;
using Domain.DTO;

namespace Domain.Mapper
{
    public static class CategoryMapper
    {
        public static CategoryDTO CategoryToDTO(Category category)
        {
            var newDTO = new CategoryDTO
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                Schema = category.Schema,
                SubCategories = category.SubCategories.Select(SubCategoryToDTO).ToList()
            };
            return newDTO;
        }

        public static SubCategoryDTO SubCategoryToDTO(SubCategory subCategory)
        {
            var newDTO = new SubCategoryDTO
            {
                Id = subCategory.Id,
                Name = subCategory.Name,
                Description = subCategory.Description,
                Schema = subCategory.Schema,
                Category = CategoryToDTO(subCategory.Category)
            };
            return newDTO;
        }
    }
}
