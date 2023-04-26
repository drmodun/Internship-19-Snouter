using Domain.DTO;

namespace Domain.Contracts.Response.Subcategory
{
    public class GetAllSubcategoriesResponse
    {
        public List<SubCategoryDTO> SubCategories { get; set; }
    }
}
