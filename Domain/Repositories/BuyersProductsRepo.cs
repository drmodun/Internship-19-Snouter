using Data.Entities;
using Data.Entities.Models;
using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories
{
    public class BuyersProductsRepo : IBuyersProductsRepo
    {
        private readonly ShopContext _shopContext = new ShopContextFactory().CreateDbContext(null);

        public BuyersProductsRepo(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public async Task<bool> CreateConnection(BuyersProducts buyersProducts, CancellationToken cancellationToken = default)
        {
            try
            {
                await _shopContext.BuyersProducts.AddAsync(buyersProducts);
                return await _shopContext.SaveChangesAsync(cancellationToken) > 0;
            }
            catch (DbUpdateException)
            {

                return false;
            }
        }
        public async Task<BuyersProducts> GetConnection(Guid productId, Guid buyerId, CancellationToken cancellationToken = default)
        {
            return await Task.FromResult(await _shopContext.BuyersProducts.FirstOrDefaultAsync(bp => bp.ProductId == productId && bp.BuyerId == buyerId, cancellationToken));
        }

        public async Task<List<BuyersProducts>> GetAllConnections()
        {
            return await Task.FromResult(_shopContext.BuyersProducts.ToList());
        }
        public async Task<bool> DeleteConnection(Guid productId, Guid buyerId, CancellationToken cancellationToken = default)
        {
            try
            {
                var connectionToDelete = await GetConnection(productId, buyerId);
                if (connectionToDelete == null) return false;
                _shopContext.Remove(connectionToDelete);
                return await _shopContext.SaveChangesAsync(cancellationToken) > 0;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }
        public async Task<bool> UpdateConnection(BuyersProducts buyersProducts, CancellationToken cancellationToken = default)
        {
            try
            {
                var connectionToUpdate = await GetConnection(buyersProducts.ProductId, buyersProducts.BuyerId, cancellationToken);
                if (connectionToUpdate == null) return false;
                _shopContext.Remove(connectionToUpdate);
                await _shopContext.AddAsync(buyersProducts);
                return await _shopContext.SaveChangesAsync(cancellationToken) > 0;
            }
            catch (DbUpdateException) { return false; }
        }

    }
}
