using Domain.Constants;
using Domain.Contracts.Requests.Product;
using Domain.Contracts.Response.Product;
using Domain.Services.Implmentations;
using Domain.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    public class ProductsServicesController : ControllerBase
    {
        private readonly IProductsServices _productsService;

        public ProductsServicesController(IProductsServices productsService)
        {
            _productsService = productsService;
        }
        [AllowAnonymous]
        [HttpGet(Routes.Products.Get)]
        public async Task<ActionResult<GetProductResponse>> Get([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var request = new GetProductRequest { Id = id };
            var response = await _productsService.GetProductService(request, cancellationToken);
            if (response.Product == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
        [Authorize(AuthConstants.TrustMemberPolicyName)]
        [HttpPost(Routes.Products.Create)]
        public async Task<ActionResult<CreateProductResponse>> Post([FromBody] CreateProductRequest request, CancellationToken cancellationToken)
        {
            var response = await _productsService.CreateProductService(request, cancellationToken);
            if (response.Product == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [Authorize(AuthConstants.TrustMemberPolicyName)]
        [HttpPut(Routes.Products.Update)]
        public async Task<ActionResult<UpdateProductResponse>> Put([FromRoute] Guid id , [FromBody] CreateProductRequest request, CancellationToken cancellationToken)
        {
            var updateRequest = new UpdateProductRequest { 
                Id = id, 
                Name = request.Name, 
                CategoryId = request.CategoryId, 
                Description = request.Description, ExtraProperties = request.ExtraProperties, SubProperties = request.SubProperties, Images = request.Images, LocationId = request.LocationId, SellerId = request.SellerId, SubCategoryId = request.SubCategoryId, Quantity = request.Quantity };
            var response = await _productsService.UpdateProductService(updateRequest, cancellationToken);
            if (response.Product == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [Authorize(AuthConstants.TrustMemberPolicyName)]
        [HttpDelete(Routes.Products.Delete)]
        public async Task<ActionResult<DeleteProductResponse>> Delete([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var request = new DeleteProductRequest { Id = id };
            var response = await _productsService.DeleteProductService(request, cancellationToken);
            if (!response.Success)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [AllowAnonymous]
        [HttpGet(Routes.Products.GetAll)]
        public async Task<ActionResult<GetAllProductsResponse>> GetAll()
        {
            var response = await _productsService.GetAllProductsService();
            if (response.Products==null)
                return BadRequest();    
            return Ok(response);
        }
    }
}