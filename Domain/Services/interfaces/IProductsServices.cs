using Domain.Contracts.Requests.Product;
using Domain.Contracts.Response.Product;

namespace Domain.Services.Interfaces
{
    public interface IProductsServices // use ProductsServices class to write this interface
    {
        public Task<GetAllProductsResponse> GetAllProductsService();
        public Task<GetProductResponse> GetProductService(GetProductRequest request, CancellationToken cancellationToken = default);
        public Task<CreateProductResponse> CreateProductService(CreateProductRequest request, CancellationToken cancellationToken = default);
        public Task<DeleteProductResponse> DeleteProductService(DeleteProductRequest request, CancellationToken cancellationToken = default);
        public Task<UpdateProductResponse> UpdateProductService(UpdateProductRequest request, CancellationToken cancellationToken = default);
    }
}
