using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Factories
{
    public static class ContextFactory
    {
        public static ShopContext GetShopContext()
        {
            var options = new DbContextOptionsBuilder()
                .UseNpgsql( /*connection string here */)
                .Options;
            return new ShopContext(options);
        }
    }
}
