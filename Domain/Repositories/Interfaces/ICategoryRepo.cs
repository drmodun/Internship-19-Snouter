using Data.Entities.Models;

namespace Domain.Repositories.Inter
{
    public interface ICategoryRepo
    {
        public Task<Category> GetCategoryById(Guid id, CancellationToken cancellationToken = default);
        public Task<List<Category>> GetAllCategories(CancellationToken cancellationToken);
        public Task<bool> CreateCategory(Category Category, CancellationToken cancellationToken = default);
        public Task<bool> UpdateCategory(Category Category, CancellationToken cancellationToken = default);
        public Task<bool> DeleteCategory(Guid id, CancellationToken cancellationToken = default);

    }
}
