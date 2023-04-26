using Domain.DTO;

namespace Domain.Contracts.Response.Category
{
    public class GetAllCategoriesReponse
    {
        public List<CategoryDTO> Categories { get; set; }
    }
}
