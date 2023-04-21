using Domain.Contracts.Requests.SubCategory;
using Domain.Contracts.Response.Subcategory;
using Domain.Contracts.Response.SubCategory;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    public class SubCategoryController : ControllerBase
    {
        private readonly SubCategoryServices _subCategoryService;
        public SubCategoryController(SubCategoryServices subCategoryService)
        {
            _subCategoryService = subCategoryService;
        }
        [HttpGet(Routes.SubCategory.Get)]
        public async Task<ActionResult<GetSubcatgoryResponse>> Get([FromRoute] Guid id)
        {
            var request = new GetSubCategoryRequest { Id = id };
            var response = await _subCategoryService.GetSubCategoryService(request);
            if (response.SubCategory == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
        [HttpPost(Routes.SubCategory.Create)]
        public async Task<ActionResult<CreateSubcategoryResponse>> Post([FromBody] CreateSubcategoryRequest request)
        {
            var response = await _subCategoryService.CreateSubCategoryService(request);
            if (response.SubCategory == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [HttpPut(Routes.SubCategory.Update)]
        public async Task<ActionResult<UpdateSubcategoryReponse>> Put([FromBody] UpdateSubCategoryRequest request)
        {
            var response = await _subCategoryService.UpdateSubCategoryService(request);
            if (response.SubCategory == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [HttpDelete(Routes.SubCategory.Delete)]
        public async Task<ActionResult<DeleteSubCategoryResponse>> Delete([FromRoute] Guid id)
        {
            var request = new DeleteSubcategoryRequest { Id = id };
            var response = await _subCategoryService.DeleteSubCategoryService(request);
            if (response.Success == false)
            {
                return BadRequest();
            }
            return Ok(response);
        }
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
