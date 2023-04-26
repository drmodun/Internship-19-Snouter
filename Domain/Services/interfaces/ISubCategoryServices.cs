using Domain.Contracts.Requests.SubCategory;
using Domain.Contracts.Response.Subcategory;
using Domain.Contracts.Response.SubCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Interfaces
{
    public interface ISubCategoryServices
    {
        public Task<GetSubcatgoryResponse> GetSubCategoryService(GetSubCategoryRequest request, CancellationToken cancellationToken = default);
        public Task<GetAllSubcategoriesResponse> GetAllSubCategoriesService();
        public Task<CreateSubcategoryResponse> CreateSubCategoryService(CreateSubcategoryRequest request, CancellationToken cancellationToken = default);
        public Task<DeleteSubCategoryResponse> DeleteSubCategoryService(DeleteSubcategoryRequest request, CancellationToken cancellationToken = default);
        public Task<UpdateSubcategoryReponse> UpdateSubCategoryService(UpdateSubCategoryRequest request, CancellationToken cancellationToken = default);> CreateSubCategoryService(CreateSubCategoryRequest request, CancellationToken cancellationToken = default);
       }
}
