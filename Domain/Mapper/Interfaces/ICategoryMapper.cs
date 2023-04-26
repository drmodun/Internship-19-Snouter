using Data.Entities.Models;
using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mapper.Interfaces
{
    public interface ICategoryMapper // use CategoryMapper class to write this interface
    {
        public CategoryDTO CategoryToDTO(Category category);
        public SubCategoryDTO SubCategoryToDTO(SubCategory subCategory);

        

    }
}
