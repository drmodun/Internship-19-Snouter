using Data.Entities;
using Domain.Contracts.Requests.Category;
using Domain.Contracts.Response.Category;
using Domain.Contracts.Response.User;
using Domain.Mapper;
using Domain.Repositories;
using Domain.Validators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class CategoryServices
    {
        private readonly CategoryRepo _categoryRepository;
        private readonly EntityMaker _entityMaker;
        private readonly CategoryMapper _categoryMapper;
        private readonly CategoriesValidator _categoriesValidator;

        public CategoryServices(CategoryRepo categoryRepository, EntityMaker entityMaker, CategoryMapper categoryMapper, CategoriesValidator validationRules)
        {
            _categoryRepository = categoryRepository;
            _entityMaker = entityMaker;
            _categoryMapper = categoryMapper;
            _categoriesValidator = validationRules;
        }

        public async Task<GetCategoryReponse> GetCategoryService(GetCategoryRequest request)
        {
            var category = await _categoryRepository.GetCategoryById(request.Id);
            if (category == null)
            {
                return new GetCategoryReponse
                {
                    Success = false,
                    StatusCode = System.Net.HttpStatusCode.NotFound,
                    Category = null
                };
            };
            return new GetCategoryReponse
            {
                Success = true,
                Category = _categoryMapper.CategoryToDTO(category),
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }
        public async Task<GetAllCategoriesReponse> GetAllCategoriesService()
        {
            var categories = await _categoryRepository.GetAllCategories();
            return new GetAllCategoriesReponse
            {
                Categories = categories.Select(_categoryMapper.CategoryToDTO).ToList()
            };
        }
        public async Task<CreateCategoryResponse> CreateCategoryService(CreateCategoryRequest request)
        {
            var newCategory = _entityMaker.RequestToNewCategory(request);
            if (newCategory == null)
            {
                return new CreateCategoryResponse
                {
                    Success = false,
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Category = null
                };
            }
            if (newCategory.Schema == null)
                return new CreateCategoryResponse
                {
                    Success = false,
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Category = null
                };
            var validation =_categoriesValidator.ValidateAndThrowAsync(newCategory);
            var addition = await _categoryRepository.CreateCategory(newCategory);
            if (!addition)
                return new CreateCategoryResponse
                {
                    Success = false,
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Category = null
                };
            return new CreateCategoryResponse
            {
                Success = true,
                StatusCode = System.Net.HttpStatusCode.OK,
                Category = _categoryMapper.CategoryToDTO(newCategory)

            };
        }
        public async Task<UpdateCategoryReponse> UpdateCategoryService(UpdateCategoryRequest request)
        {
            var categoryToUpdate = _entityMaker.RequestToUpdatedCategory(request);
            await _categoriesValidator.ValidateAndThrowAsync(categoryToUpdate);
            var update = await _categoryRepository.UpdateCategory(categoryToUpdate); 
            if (!update)
            {
                return new UpdateCategoryReponse
                {
                    Success = false,
                    Category = null,
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                };
            }
            return new UpdateCategoryReponse
            {
                Success = true,
                StatusCode = System.Net.HttpStatusCode.OK,
                Category = _categoryMapper.CategoryToDTO(categoryToUpdate)
            };
        }
        public async Task<DeleteCategoryResponse> DeleteCategoryService(DeleteCategoryRequest request)
        {
            var deletion = await _categoryRepository.DeleteCategory(request.Id);
            if (deletion == false)
            {
                return new DeleteCategoryResponse
                {
                    Success = false,
                    StatusCode = System.Net.HttpStatusCode.NotFound,
                };
            }
            return new DeleteCategoryResponse
            {
                Success = true,
                StatusCode = System.Net.HttpStatusCode.OK,
            };
        }
    }
}
