using Domain.Contracts.Requests.Product;
using Domain.Contracts.Response.Product;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    public class ProductsServicesController : ControllerBase
    {
        private readonly ProductsServices _productsService;

        public ProductsServicesController(ProductsServices productsService)
        {
            _productsService = productsService;
        }

        [HttpGet(Routes.Products.Get)]
        public async Task<ActionResult<GetProductResponse>> Get([FromRoute] Guid id)
        {
            var request = new GetProductRequest { Id = id };
            var response = await _productsService.GetProductService(request);
            if (response.Product == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
        [HttpPost(Routes.Products.Create)]
        public async Task<ActionResult<CreateProductResponse>> Post([FromBody] CreateProductRequest request)
        {
            var response = await _productsService.CreateProductService(request);
            if (response.Product == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [HttpPut(Routes.Products.Update)]
        public async Task<ActionResult<UpdateProductResponse>> Put([FromRoute] Guid id , [FromBody] CreateProductRequest request)
        {
            var updateRequest = new UpdateProductRequest { 
                Id = id, 
                Name = request.Name, 
                CategoryId = request.CategoryId, 
                Description = request.Description, ExtraProperties = request.ExtraProperties, SubProperties = request.SubProperties, Images = request.Images, LocationId = request.LocationId, SellerId = request.SellerId, SubCategoryId = request.SubCategoryId, Quantity = request.Quantity };
            var response = await _productsService.UpdateProductService(updateRequest);
            if (response.Product == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
        [HttpDelete(Routes.Products.Delete)]
        public async Task<ActionResult<DeleteProductResponse>> Delete([FromRoute] Guid id)
        {
            var request = new DeleteProductRequest { Id = id };
            var response = await _productsService.DeleteProductService(request);
            if (!response.Success)
            {
                return BadRequest();
            }
            return Ok(response);
        }
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