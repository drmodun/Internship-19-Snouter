using Data.Entities;
using Data.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class CategoryRepo
    {
        private readonly ShopContext _context = new ShopContextFactory().CreateDbContext(null);

        public CategoryRepo(ShopContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateCategory(Category category)
        {
            await _context.AddAsync(category);
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<Category> GetCategoryById(Guid id)
        {
            return await Task.FromResult(await _context.Categories.FirstOrDefaultAsync(c => c.Id == id));

        }
        public async Task<List<Category>> GetAllCategories()
        {
            return await Task.FromResult(_context.Categories.ToList());
        }

        public async Task<bool> UpdateCategory(Category category)
        {
            var removal = await DeleteCategory(category.Id);
            if (!removal) 
                return false;
            var addition = await CreateCategory(category);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteCategory(Guid id)
        {
            var categoryToDelete = await _context.Categories.FirstOrDefaultAsync();
            if (categoryToDelete == null)
                return false;
            _context.Categories.Remove(categoryToDelete);
            return await _context.SaveChangesAsync() > 0;
        }

    }
}
