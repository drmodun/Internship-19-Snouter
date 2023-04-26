using Data.Entities.Models;

namespace Domain.Repositories.Interfaces
{
    public interface ISubCategoryRepo
    {
        public Task<SubCategory> GetSubCategoryById(Guid id, CancellationToken cancellationToken = default);
        public Task<List<SubCategory>> GetAllSubCategories();
        public Task<bool> CreateSubCategory(SubCategory subCategory, CancellationToken cancellationToken = default);
        public Task<bool> UpdateSubCategory(SubCategory subCategory, CancellationToken cancellationToken = default);
        public Task<bool> DeleteSubCategory(Guid id, CancellationToken cancellationToken = default);
    }
}
