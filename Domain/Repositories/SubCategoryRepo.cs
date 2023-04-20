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
    public class SubCategoryRepo
    {
        private readonly ShopContext _shopContext;


        public async Task<List<SubCategory>> GetAllSubCategories()
        {
            return await Task.FromResult(_shopContext.SubCategories.ToList());
        }

        public async Task<SubCategory> GetSubCategoryById(Guid id)
        {
            return await _shopContext.SubCategories.FirstOrDefaultAsync(x => x.Id == id);
        }

        /*public async Task<SubCategory> GetSubCategoryBySlug(string slug)
    {
            return await _shopContext.SubCategories.FirstOrDefaultAsync(x => x.Slug == slug);
        }*/

        public async Task<bool> CreateSubCategory(SubCategory subCategory)
        {
            await _shopContext.SubCategories.AddAsync(subCategory);
            return await _shopContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateSubCategory(SubCategory subCategory)
        {
            var removal = await DeleteSubCategory(subCategory.Id);
            if (!removal) { return false; }
            var addition = await CreateSubCategory(subCategory);
            if (!addition) { return false; }
            
            return await _shopContext.SaveChangesAsync() > 0 ;
        }

        public async Task<bool> DeleteSubCategory(Guid id)
        {
            var subCategory = await GetSubCategoryById(id);
            if (subCategory == null) return false;
            _shopContext.SubCategories.Remove(subCategory);
            return await _shopContext.SaveChangesAsync() > 0;
        }
    }
}
