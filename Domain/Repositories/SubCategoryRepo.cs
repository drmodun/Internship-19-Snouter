﻿using System;
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
        private readonly ShopContext _shopContext = new ShopContextFactory().CreateDbContext(null);

        public SubCategoryRepo(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public async Task<List<SubCategory>> GetAllSubCategories()
        {
            return await Task.FromResult(_shopContext.SubCategories.ToList());
        }

        public async Task<SubCategory> GetSubCategoryById(Guid id)
        {
            return await _shopContext.SubCategories.FirstOrDefaultAsync(x => x.Id == id);
        }

        /*public async Task<SubCategory> GetSubCategoryBySlug(string? Slug)
    {
            return await _shopContext.SubCategories.FirstOrDefaultAsync(x => x.Slug ==? Slug);
        }*/

        public async Task<bool> CreateSubCategory(SubCategory subCategory)
        {
            try
            {
                await _shopContext.SubCategories.AddAsync(subCategory);
                return await _shopContext.SaveChangesAsync() > 0;
            }
            catch (DbUpdateException)
            {

                return false;
            }
        }

        public async Task<bool> UpdateSubCategory(SubCategory subCategory)
        {
            try
            {
                var removal = await DeleteSubCategory(subCategory.Id);
                if (!removal) { return false; }
                return await CreateSubCategory(subCategory);
            }
            catch (DbUpdateException)
            {
                return false;
            }
            
        }

        public async Task<bool> DeleteSubCategory(Guid id)
        {
            try
            {
                var subCategory = await GetSubCategoryById(id);
                if (subCategory == null) return false;
                _shopContext.SubCategories.Remove(subCategory);
                return await _shopContext.SaveChangesAsync() > 0;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }
    }
}
