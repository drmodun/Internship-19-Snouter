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
        public async Task<bool> CreateCategory(Category category, CancellationToken cancellationToken = default)
        {
            try
            {
                await _context.AddAsync(category);
                return await _context.SaveChangesAsync(cancellationToken) > 0;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }
        public async Task<Category> GetCategoryById(Guid id, CancellationToken cancellationToken = default)
        {
            try
            {
                return await Task.FromResult(await _context.Categories.FirstOrDefaultAsync(c => c.Id == id, cancellationToken));
            }
            catch (DbUpdateException)
            {
                return null;
            }

        }
        public async Task<List<Category>> GetAllCategories(CancellationToken cancellationToken = default)
        {
            return await Task.FromResult(_context.Categories.ToList());
        }

        public async Task<bool> UpdateCategory(Category category, CancellationToken cancellationToken = default)
        {
            try
            {
                var categoryToUpdate = await _context.Categories.FirstOrDefaultAsync(c => c.Id == category.Id, cancellationToken);
                if (categoryToUpdate == null)
                    return false;
                _context.Categories.Remove(categoryToUpdate);
                await _context.AddAsync(category);
                return await _context.SaveChangesAsync(cancellationToken) > 0;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }

        public async Task<bool> DeleteCategory(Guid id, CancellationToken cancellationToken = default)
        {

            var categoryToDelete = await _context.Categories.FirstOrDefaultAsync(x=>x.Id==id);
            if (categoryToDelete == null)
                return false;
            _context.Categories.Remove(categoryToDelete);
            return await _context.SaveChangesAsync(cancellationToken) > 0;
        }



    }
}
