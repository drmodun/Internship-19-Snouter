using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Entities.Models;
using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories
{
    public class SubCategoryRepo : ISubCategoryRepo
    {
        private readonly ShopContext _shopContext = new ShopContextFactory().CreateDbContext(null);

        public SubCategoryRepo(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public async Task<List<SubCategory>> GetAllSubCategories()
        {
            return await Task.FromResult(_shopContext.SubCategories.ToList());
        }

        public async Task<SubCategory> GetSubCategoryById(Guid id, CancellationToken cancellationToken = default)
        {
            return await _shopContext.SubCategories.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }


        public async Task<bool> CreateSubCategory(SubCategory subCategory, CancellationToken cancellationToken = default)
        {
            try
            {
                await _shopContext.SubCategories.AddAsync(subCategory);
                return await _shopContext.SaveChangesAsync(cancellationToken) > 0;
            }
            catch (DbUpdateException)
            {

                return false;
            }
        }

        public async Task<bool> UpdateSubCategory(SubCategory subCategory, CancellationToken cancellationToken = default)
        {
            try
            {
                var subCategoryToUpdate = await GetSubCategoryById(subCategory.Id);
                if (subCategoryToUpdate == null) { return false; }
                _shopContext.SubCategories.Remove(subCategoryToUpdate);
                await _shopContext.AddAsync(subCategory);
                return await _shopContext.SaveChangesAsync(cancellationToken) > 0;
            }
            catch (DbUpdateException)
            {
                return false;
            }
            
        }

        public async Task<bool> DeleteSubCategory(Guid id, CancellationToken cancellationToken = default)
        {
            try
            {
                var subCategory = await GetSubCategoryById(id);
                if (subCategory == null) return false;
                _shopContext.SubCategories.Remove(subCategory);
                return await _shopContext.SaveChangesAsync(cancellationToken) > 0;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }
    }
}
