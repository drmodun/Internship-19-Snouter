using Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories.Interfaces
{
    public interface IBuyersProductsRepo
    {
         public Task<BuyersProducts> GetConnection(Guid productid, Guid buyerId,  CancellationToken cancellationToken = default);
        public Task<List<BuyersProducts>> GetAllConnections();
        public Task<bool> CreateConnection(BuyersProducts buyersProducts, CancellationToken cancellationToken = default);
        public Task<bool> UpdateConnection(BuyersProducts buyersProducts, CancellationToken cancellationToken = default);
        public Task<bool> DeleteConnection(Guid productid, Guid buyerId, CancellationToken cancellationToken = default);
   
    }
}
