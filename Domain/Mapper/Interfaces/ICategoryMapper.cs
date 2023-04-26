using Data.Entities.Models;
using Domain.DTO;

namespace Domain.Mapper.Interfaces
{
    public interface ICategoryMapper // use CategoryMapper class to write this interface
    {
        public CategoryDTO CategoryToDTO(Category category);
        public SubCategoryDTO SubCategoryToDTO(SubCategory subCategory);



    }
}
