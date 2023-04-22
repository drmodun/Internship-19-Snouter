using Domain.Contracts.Requests.Category;
using Domain.Contracts.Requests.SubCategory;
using Domain.Contracts.Response.Category;
using Domain.Contracts.Response.Subcategory;
using Domain.Contracts.Response.SubCategory;
using Domain.Mapper;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class SubCategoryServices
    {
        private readonly SubCategoryRepo _subCategoryRepository;
        private readonly EntityMaker _entityMaker;
        private readonly CategoryMapper _categoryMapper;
        
        public SubCategoryServices(SubCategoryRepo subCategoryRepository, EntityMaker entityMaker, CategoryMapper categoryMapper)
        {
            _subCategoryRepository = subCategoryRepository;
            _entityMaker = entityMaker;
            _categoryMapper = categoryMapper;
        }
        public async Task<GetSubcatgoryResponse> GetSubCategoryService(GetSubCategoryRequest request)
        {
            var category = await _subCategoryRepository.GetSubCategoryById(request.Id);
            if (category == null)
            {
                return new GetSubcatgoryResponse
                {
                    Success = false,
                    StatusCode = System.Net.HttpStatusCode.NotFound,
                    SubCategory = null
                };
            };
            return new GetSubcatgoryResponse
            {
                Success = true,
                SubCategory = CategoryMapper.SubCategoryToDTO(category),
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }
        public async Task<GetAllSubcategoriesResponse> GetAllSubCategoriesService()
        {
            var categories = await _subCategoryRepository.GetAllSubCategories();
            return new GetAllSubcategoriesResponse
            {
                SubCategories = categories.Select(CategoryMapper.SubCategoryToDTO).ToList()
            };
        }
        public async Task<CreateSubcategoryResponse> CreateSubCategoryService(CreateSubcategoryRequest request)
        {
            var newCategory = _entityMaker.RequestToNewSubcategory(request);
            if (newCategory == null)
            {
                return new CreateSubcategoryResponse
                {
                    Success = false,
                    Status = System.Net.HttpStatusCode.BadRequest,
                    SubCategory = null
                };
            }
            if (newCategory.Schema == null)
                return new CreateSubcategoryResponse
                {
                    Success = false,
                    Status = System.Net.HttpStatusCode.BadRequest,
                    SubCategory = null
                };
            var addition = await _subCategoryRepository.CreateSubCategory(newCategory);
            if (!addition)
                return new CreateSubcategoryResponse
                {
                    Success = false,
                    Status = System.Net.HttpStatusCode.BadRequest,
                    SubCategory = null
                };
            return new CreateSubcategoryResponse
            {
                Success = true,
                Status = System.Net.HttpStatusCode.OK,
                SubCategory = CategoryMapper.SubCategoryToDTO(newCategory)

            };
        }
        public async Task<UpdateSubcategoryReponse> UpdateSubCategoryService(UpdateSubCategoryRequest request)
        {
            var categoryToUpdate = _entityMaker.RequestToUpdatedSubcategory(request);
            var update = await _subCategoryRepository.UpdateSubCategory(categoryToUpdate);
            if (!update)
            {
                return new UpdateSubcategoryReponse
                {
                    Success = false,
                   SubCategory = null,
                    Status = System.Net.HttpStatusCode.BadRequest,
                };
            }
            return new UpdateSubcategoryReponse
            {
                Success = true,
                Status = System.Net.HttpStatusCode.OK,
                SubCategory =   CategoryMapper.SubCategoryToDTO(categoryToUpdate)
            };
        }
        public async Task<DeleteSubCategoryResponse> DeleteSubCategoryService(DeleteSubcategoryRequest request)
        {
            var deletion = await _subCategoryRepository.DeleteSubCategory(request.Id);
            if (!deletion)
            {
                return new DeleteSubCategoryResponse
                {
                    Success = false,
                    StatusCode = System.Net.HttpStatusCode.NotFound,
                };
            }
            return new DeleteSubCategoryResponse
            {
                Success = true,
                StatusCode = System.Net.HttpStatusCode.OK,
            };
        }
    }
}
