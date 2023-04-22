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

        public async Task<bool> AddProduct(Product product)
        {
            try
            {
                await _context.Products.AddAsync(product);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (DbUpdateException)
            {

                return false;
            }
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            try
            {
                var removal = await DeleteProduct(product.Id);
                if (!removal)
                    return false;
                var addition = await AddProduct(product);
                if (!addition) return false;
                return await _context.SaveChangesAsync() > 0;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }


        public async Task<bool> DeleteProduct(Guid id)
        {
            try
            {
                var product = await GetProductById(id);
                if (product == null)
                    return false;
                _context.Products.Remove(product);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }

        public async Task<bool> ProductExists(Guid id)
        {
            return await Task.FromResult(_context.Products.Any(p => p.Id == id));
        }   

    }
}
