using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories
{
    public class ProductRepo
    {
        private readonly ShopContext _context = new ShopContextFactory().CreateDbContext(null);

        public ProductRepo(ShopContext context)
        {
            _context = context;
        }

        public async Task<Product> GetProductById(Guid id, CancellationToken cancellationToken = default)
        {
            return await Task.FromResult(_context.Products.FindAsync(id, cancellationToken).Result);
        }

        public async Task<Product> GetProductByName(string name)
        {
            return await Task.FromResult(_context.Products.FirstOrDefault(p => p.Name == name));
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await Task.FromResult(_context.Products.ToList());
        }

        public async Task<bool> AddProduct(Product product, CancellationToken cancellationToken = default)
        {
            try
            {
                await _context.Products.AddAsync(product);
                return await _context.SaveChangesAsync(cancellationToken) > 0;
            }
            catch (DbUpdateException)
            {

                return false;
            }
        }

        public async Task<bool> UpdateProduct(Product product, CancellationToken cancellationToken = default)
        {
            
                var productToUpdate = await _context.Products.FirstOrDefaultAsync(x=>x.Id==product.Id);
                if (productToUpdate == null) 
                { 
                    return false; 
                }
                _context.Products.Remove(productToUpdate);
                await _context.AddAsync(product);
                return await _context.SaveChangesAsync(cancellationToken) > 0;
            
        }


        public async Task<bool> DeleteProduct(Guid id, CancellationToken cancellationToken = default)
        {
            try
            {
                var product = await GetProductById(id);
                if (product == null)
                    return false;
                _context.Products.Remove(product);
                return await _context.SaveChangesAsync(cancellationToken) > 0;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }

        public async Task<bool> ProductExists(Guid id, CancellationToken cancellationToken = default)
        {
            return await Task.FromResult(_context.Products.Any(p => p.Id == id));
        }   

    }
}
