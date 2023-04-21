using Data.Entities;
using Domain.Contracts.Requests.Category;
using Domain.Contracts.Response.Category;
using Domain.Contracts.Response.User;
using Domain.Mapper;
using Domain.Repositories;
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
                Category = CategoryMapper.CategoryToDTO(category),
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }
        public async Task<GetAllCategoriesReponse> GetAllCategoriesService()
        {
            var categories = await _categoryRepository.GetAllCategories();
            return new GetAllCategoriesReponse
            {
                Categories = categories.Select(CategoryMapper.CategoryToDTO).ToList()
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
                Category = CategoryMapper.CategoryToDTO(newCategory)

            };
        }
        public async Task<UpdateCategoryReponse> UpdateCategoryService(UpdateCategoryRequest request)
        {
            var categoryToUpdate = _entityMaker.RequestToUpdatedCategory(request);
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
                Category = CategoryMapper.CategoryToDTO(categoryToUpdate)
            };
        }
        public async Task<DeleteCategoryResponse> DeleteCategoryService(DeleteCategoryRequest request)
        {
            var deletion = await _categoryRepository.DeleteCategory(request.Id);
            if (!deletion)
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
