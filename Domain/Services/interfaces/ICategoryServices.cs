using Domain.Contracts.Requests.Category;
using Domain.Contracts.Response.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Interfaces
{
    public interface ICategoryServices
    {
        public Task<GetAllCategoriesReponse> GetAllCategoriesService();
        public Task<GetCategoryReponse> GetCategoryService(GetCategoryRequest request, CancellationToken cancellationToken = default);
        public Task<CreateCategoryResponse> CreateCategoryService(CreateCategoryRequest request, CancellationToken cancellationToken = default);
        public Task<DeleteCategoryResponse> DeleteCategoryService(DeleteCategoryRequest request, CancellationToken cancellationToken = default);
        public Task<UpdateCategoryReponse> UpdateCategoryService(UpdateCategoryRequest request, CancellationToken cancellationToken = default);
    }
}
