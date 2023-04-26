using Domain.Contracts.Requests.Category;
using Domain.Contracts.Requests.SubCategory;
using Domain.Contracts.Response.Category;
using Domain.Contracts.Response.Subcategory;
using Domain.Contracts.Response.SubCategory;
using Domain.Mapper.Implementaions;
using Domain.Mapper.Interfaces;
using Domain.Repositories;
using Domain.Repositories.Interfaces;
using Domain.Services.Interfaces;
using Domain.Validators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Implmentations
{
    public class SubCategoryServices : ISubCategoryServices
    {
        private readonly ISubCategoryRepo _subCategoryRepository;
        private readonly EntityMaker _entityMaker;
        private readonly ICategoryMapper _categoryMapper;
        private readonly SubCategoriesValidator _subCategoriesValidator;

        public SubCategoryServices(ISubCategoryRepo subCategoryRepository, EntityMaker entityMaker, ICategoryMapper categoryMapper, SubCategoriesValidator validationRules)
        {
            _subCategoryRepository = subCategoryRepository;
            _entityMaker = entityMaker;
            _categoryMapper = categoryMapper;
            _subCategoriesValidator = validationRules;
        }
        public async Task<GetSubcatgoryResponse> GetSubCategoryService(GetSubCategoryRequest request, CancellationToken cancellationToken = default)
        {
            var category = await _subCategoryRepository.GetSubCategoryById(request.Id, cancellationToken);
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
                SubCategory = _categoryMapper.SubCategoryToDTO(category),
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }
        public async Task<GetAllSubcategoriesResponse> GetAllSubCategoriesService()
        {
            var categories = await _subCategoryRepository.GetAllSubCategories();
            return new GetAllSubcategoriesResponse
            {
                SubCategories = categories.Select(_categoryMapper.SubCategoryToDTO).ToList()
            };
        }
        public async Task<CreateSubcategoryResponse> CreateSubCategoryService(CreateSubcategoryRequest request, CancellationToken cancellationToken = default)
        {
            var newCategory = _entityMaker.RequestToNewSubcategory(request);
            await _subCategoriesValidator.ValidateAndThrowAsync(newCategory);
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
            var addition = await _subCategoryRepository.CreateSubCategory(newCategory, cancellationToken);
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
                SubCategory = _categoryMapper.SubCategoryToDTO(newCategory)

            };
        }
        public async Task<UpdateSubcategoryReponse> UpdateSubCategoryService(UpdateSubCategoryRequest request, CancellationToken cancellationToken = default)
        {
            var categoryToUpdate = _entityMaker.RequestToUpdatedSubcategory(request);
            await _subCategoriesValidator.ValidateAndThrowAsync(categoryToUpdate);
            if (categoryToUpdate == null)
            {
                return new UpdateSubcategoryReponse
                {
                    Success = false,
                    SubCategory = null,
                    Status = System.Net.HttpStatusCode.BadRequest,
                };
            }
            var update = await _subCategoryRepository.UpdateSubCategory(categoryToUpdate, cancellationToken);
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
                SubCategory = _categoryMapper.SubCategoryToDTO(categoryToUpdate)
            };
        }
        public async Task<DeleteSubCategoryResponse> DeleteSubCategoryService(DeleteSubcategoryRequest request, CancellationToken cancellationToken = default)
        {
            var deletion = await _subCategoryRepository.DeleteSubCategory(request.Id, cancellationToken);
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
