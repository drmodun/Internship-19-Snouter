using Data.Entities;
using Data.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class BuyersProductsRepo
    {
        private readonly ShopContext _shopContext = new ShopContextFactory().CreateDbContext(null);

        public BuyersProductsRepo(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public async Task<bool> CreateConnection(BuyersProducts buyersProducts)
        {
            await  _shopContext.BuyersProducts.AddAsync(buyersProducts);
            return await _shopContext.SaveChangesAsync() > 0;
        }
        public async Task<BuyersProducts> GetConnection(Guid productId, Guid buyerId) {
            return await Task.FromResult(await _shopContext.BuyersProducts.FirstOrDefaultAsync(bp=> bp.ProductId==productId && bp.BuyerId==buyerId));
        }

        public async Task<List<BuyersProducts>> GetAllConnections()
        {
            return await Task.FromResult(_shopContext.BuyersProducts.ToList());
        }
        public async Task<bool> DeleteConnection(Guid productId, Guid buyerId)
        {
            var connectionToDelete = await GetConnection(productId, buyerId);
            if (connectionToDelete==null) return false;
            _shopContext.Remove(connectionToDelete);
            return await _shopContext.SaveChangesAsync() > 0;
        }
        public async Task<bool> UpdateConnection(BuyersProducts buyersProducts)
        {
            var removal = await DeleteConnection(buyersProducts.ProductId, buyersProducts.BuyerId);
            if (!removal) return false;
            var addition = await CreateConnection(buyersProducts);
            if (!addition) return false;
            return await _shopContext.SaveChangesAsync() > 0;
        }

    }
}
