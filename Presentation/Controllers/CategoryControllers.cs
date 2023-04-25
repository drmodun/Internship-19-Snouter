using Domain.Constants;
using Domain.Contracts.Requests.Category;
using Domain.Contracts.Response.Category;
using Domain.Services;
using Microsoft.AspNetCore.Authorization;
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
        [AllowAnonymous]
        [HttpGet(Routes.Category.Get)]
        public async Task<ActionResult<GetCategoryReponse>> Get([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var request = new GetCategoryRequest { Id = id };
            var response = await _categoryService.GetCategoryService(request, cancellationToken);
            if (response.Category == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
        [Authorize(AuthConstants.AdminUserPolicyName)]
        [HttpPost(Routes.Category.Create)]
        public async Task<ActionResult<CreateCategoryResponse>> Post([FromBody] CreateCategoryRequest request, CancellationToken cancellationToken)
        {
            var response = await _categoryService.CreateCategoryService(request, cancellationToken);
            if (response.Category == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [Authorize(AuthConstants.AdminUserPolicyName)]
        [HttpPut(Routes.Category.Update)]
        public async Task<ActionResult<UpdateCategoryReponse>> Put([FromRoute] Guid id, [FromBody] CreateCategoryRequest requestCreate, CancellationToken cancellationToken)
        {
            var request = new UpdateCategoryRequest { Id = id, Name = requestCreate.Name,
                Schema = requestCreate.Schema, Description = requestCreate.Description,
            };
            var response = await _categoryService.UpdateCategoryService(request, cancellationToken);
            if (response.Success == false)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [Authorize(AuthConstants.AdminUserPolicyName)]
        [HttpDelete(Routes.Category.Delete)]
        public async Task<ActionResult<DeleteCategoryResponse>> Delete([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var request = new DeleteCategoryRequest { Id = id };
            var response = await _categoryService.DeleteCategoryService(request, cancellationToken);
            if (!response.Success)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [AllowAnonymous]
        [HttpGet(Routes.Category.GetAll)]
        public async Task<ActionResult<GetAllCategoriesReponse>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _categoryService.GetAllCategoriesService(cancellationToken);
            if (response.Categories == null)
            {
                return NotFound();
            }
            return Ok(response);
        }       
    }
}
