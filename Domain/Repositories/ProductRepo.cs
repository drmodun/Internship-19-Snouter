using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Entities.Models;

namespace Domain.Repositories
{
    public class ProductRepo
    {
        private readonly ShopContext _context;

        public async Task<Product> GetProductById(Guid id)
        {
            return await Task.FromResult(_context.Products.FindAsync(id).Result);
        }

        public async Task<Product> GetProductByName(string name)
        {
            return await Task.FromResult(_context.Products.FirstOrDefault(p => p.Name == name));
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await Task.FromResult(_context.Products.ToList());
        }

        public async Task<Product> AddProduct(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return product;
        }


        public async Task<Product> DeleteProductById(Guid id)
        {
            var product = await GetProductById(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<bool> ProductExists(Guid id)
        {
            return await Task.FromResult(_context.Products.Any(p => p.Id == id));
        }   

    }
}
