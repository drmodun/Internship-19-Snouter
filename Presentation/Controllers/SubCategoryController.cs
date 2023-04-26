using Domain.Constants;
using Domain.Contracts.Requests.SubCategory;
using Domain.Contracts.Response.Subcategory;
using Domain.Contracts.Response.SubCategory;
using Domain.Services.Implmentations;
using Domain.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    public class SubCategoryController : ControllerBase
    {
        private readonly ISubCategoryServices _subCategoryService;
        public SubCategoryController(ISubCategoryServices subCategoryService)
        {
            _subCategoryService = subCategoryService;
        }
        [AllowAnonymous]
        [HttpGet(Routes.SubCategory.Get)]
        public async Task<ActionResult<GetSubcatgoryResponse>> Get([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var request = new GetSubCategoryRequest { Id = id };
            var response = await _subCategoryService.GetSubCategoryService(request, cancellationToken);
            if (response.SubCategory == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
        [Authorize(AuthConstants.AdminUserPolicyName)]
        [HttpPost(Routes.SubCategory.Create)]
        public async Task<ActionResult<CreateSubcategoryResponse>> Post([FromBody] CreateSubcategoryRequest request, CancellationToken cancellationToken)
        {
            var response = await _subCategoryService.CreateSubCategoryService(request, cancellationToken);
            if (response.SubCategory == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [Authorize(AuthConstants.AdminUserPolicyName)]
        [HttpPut(Routes.SubCategory.Update)]
        public async Task<ActionResult<UpdateSubcategoryReponse>> Put([FromRoute] Guid id, [FromBody] CreateSubcategoryRequest requestCreate, CancellationToken cancellationToken)
        {
            var request = new UpdateSubCategoryRequest { Id = id, Name = requestCreate.Name,
                           Schema = requestCreate.Schema, Description = requestCreate.Description, CategoryId = requestCreate.CategoryId
                       };
            var response = await _subCategoryService.UpdateSubCategoryService(request, cancellationToken);
            if (response.SubCategory == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [Authorize(AuthConstants.AdminUserPolicyName)]
        [HttpDelete(Routes.SubCategory.Delete)]
        public async Task<ActionResult<DeleteSubCategoryResponse>> Delete([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var request = new DeleteSubcategoryRequest { Id = id };
            var response = await _subCategoryService.DeleteSubCategoryService(request, cancellationToken);
            if (response.Success == false)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [AllowAnonymous]
        [HttpGet(Routes.SubCategory.GetAll)]
        public async Task<ActionResult<GetAllSubcategoriesResponse>> GetAll()
        {
            var response = await _subCategoryService.GetAllSubCategoriesService();
            if (response.SubCategories == null)
            {
                return NotFound();
            }
            return Ok(response);
        }   


    }
}
