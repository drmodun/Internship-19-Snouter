using Domain.Contracts.Requests.Category;
using Domain.Contracts.Response.Category;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]

    public class CategoryControllers : ControllerBase
    {
        private readonly CategoryServices _categoryService;
        public CategoryControllers(CategoryServices categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet(Routes.Category.Get)]
        public async Task<ActionResult<GetCategoryReponse>> Get([FromRoute] Guid id)
        {
            var request = new GetCategoryRequest { Id = id };
            var response = await _categoryService.GetCategoryService(request);
            if (response.Category == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
        [HttpPost(Routes.Category.Create)]
        public async Task<ActionResult<CreateCategoryResponse>> Post([FromBody] CreateCategoryRequest request)
        {
            var response = await _categoryService.CreateCategoryService(request);
            if (response.Category == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [HttpPut(Routes.Category.Update)]
        public async Task<ActionResult<UpdateCategoryReponse>> Put([FromRoute] Guid id, [FromBody] CreateCategoryRequest requestCreate)
        {
            var request = new UpdateCategoryRequest { Id = id, Name = requestCreate.Name,
                Schema = requestCreate.Schema, Description = requestCreate.Description,
            };
            var response = await _categoryService.UpdateCategoryService(request);
            if (response.Success == false)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [HttpDelete(Routes.Category.Delete)]
        public async Task<ActionResult<DeleteCategoryResponse>> Delete([FromRoute] Guid id)
        {
            var request = new DeleteCategoryRequest { Id = id };
            var response = await _categoryService.DeleteCategoryService(request);
            if (!response.Success)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [HttpGet(Routes.Category.GetAll)]
        public async Task<ActionResult<GetAllCategoriesReponse>> GetAll()
        {
            var response = await _categoryService.GetAllCategoriesService();
            if (response.Categories == null)
            {
                return NotFound();
            }
            return Ok(response);
        }       
    }
}
