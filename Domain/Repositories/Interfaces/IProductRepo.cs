using Data.Entities.Models;

namespace Domain.Repositories.Interfaces
{
    public interface IProductRepo
    {
        public Task<Product> GetProductById(Guid id, CancellationToken cancellationToken = default);
        public Task<List<Product>> GetAllProducts();
        public Task<bool> AddProduct(Product Product, CancellationToken cancellationToken = default);
        public Task<bool> UpdateProduct(Product Product, CancellationToken cancellationToken = default);
        public Task<bool> DeleteProduct(Guid id, CancellationToken cancellationToken = default);


    }
}
