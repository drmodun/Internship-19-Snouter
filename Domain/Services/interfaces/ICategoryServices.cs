using Domain.Contracts.Requests.Category;
using Domain.Contracts.Response.Category;

namespace Domain.Services.Interfaces
{
    public interface ICategoryServices
    {
        public Task<GetAllCategoriesReponse> GetAllCategoriesService(CancellationToken cancellationToken);
        public Task<GetCategoryReponse> GetCategoryService(GetCategoryRequest request, CancellationToken cancellationToken = default);
        public Task<CreateCategoryResponse> CreateCategoryService(CreateCategoryRequest request, CancellationToken cancellationToken = default);
        public Task<DeleteCategoryResponse> DeleteCategoryService(DeleteCategoryRequest request, CancellationToken cancellationToken = default);
        public Task<UpdateCategoryReponse> UpdateCategoryService(UpdateCategoryRequest request, CancellationToken cancellationToken = default);
    }
}
