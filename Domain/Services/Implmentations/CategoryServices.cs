using Domain.Contracts.Requests.Category;
using Domain.Contracts.Response.Category;
using Domain.Mapper.Interfaces;
using Domain.Repositories;
using Domain.Repositories.Inter;
using Domain.Services.Interfaces;
using Domain.Validators;
using FluentValidation;

namespace Domain.Services.Implmentations
{
    public class CategoryServices : ICategoryServices
    {
        private readonly ICategoryRepo _categoryRepository;
        private readonly EntityMaker _entityMaker;
        private readonly ICategoryMapper _categoryMapper;
        private readonly CategoriesValidator _categoriesValidator;

        public CategoryServices(ICategoryRepo categoryRepository, EntityMaker entityMaker, ICategoryMapper categoryMapper, CategoriesValidator validationRules)
        {
            _categoryRepository = categoryRepository;
            _entityMaker = entityMaker;
            _categoryMapper = categoryMapper;
            _categoriesValidator = validationRules;
        }

        public async Task<GetCategoryReponse> GetCategoryService(GetCategoryRequest request, CancellationToken cancellationToken = default)
        {
            var category = await _categoryRepository.GetCategoryById(request.Id, cancellationToken);
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
        public async Task<GetAllCategoriesReponse> GetAllCategoriesService(CancellationToken cancellationToken = default)
        {
            var categories = await _categoryRepository.GetAllCategories(cancellationToken);
            return new GetAllCategoriesReponse
            {
                Categories = categories.Select(_categoryMapper.CategoryToDTO).ToList()
            };
        }
        public async Task<CreateCategoryResponse> CreateCategoryService(CreateCategoryRequest request, CancellationToken cancellationToken = default)
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
            var validation = _categoriesValidator.ValidateAndThrowAsync(newCategory);
            var addition = await _categoryRepository.CreateCategory(newCategory, cancellationToken);
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
        public async Task<UpdateCategoryReponse> UpdateCategoryService(UpdateCategoryRequest request, CancellationToken cancellationToken = default)
        {
            var categoryToUpdate = _entityMaker.RequestToUpdatedCategory(request);
            await _categoriesValidator.ValidateAndThrowAsync(categoryToUpdate);
            var update = await _categoryRepository.UpdateCategory(categoryToUpdate, cancellationToken);
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
        public async Task<DeleteCategoryResponse> DeleteCategoryService(DeleteCategoryRequest request, CancellationToken cancellationToken = default)
        {
            var deletion = await _categoryRepository.DeleteCategory(request.Id, cancellationToken);
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
