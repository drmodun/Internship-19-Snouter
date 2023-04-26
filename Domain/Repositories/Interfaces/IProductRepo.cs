using Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
