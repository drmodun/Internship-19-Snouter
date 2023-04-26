using Data.Entities;
using Data.Entities.Models;
using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class LocationRepo : ILocationRepo
    {
        private readonly ShopContext _shop_Context = new ShopContextFactory().CreateDbContext(null);

        public LocationRepo(ShopContext shop_Context)
        {
            _shop_Context = shop_Context;
        }
        public async Task<List<Location>> GetAllLocations()
        {
            return await _shop_Context.Locations.ToListAsync();
        }
        public async Task<Location> GetLocationById(Guid id, CancellationToken cancellationToken = default)
        {
            try
            {
                return await _shop_Context.Locations.FindAsync(id, cancellationToken);
            }
            catch (DbUpdateException)
            {
                return null;
            }
            }
        public async Task<bool> CreateLocation(Location location, CancellationToken cancellationToken = default)
        {
            try
            {
                await _shop_Context.Locations.AddAsync(location);
                return await _shop_Context.SaveChangesAsync(cancellationToken) > 0;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }
        public async Task<bool> UpdateLocation(Location location, CancellationToken cancellationToken = default)
        {
            try
            {
                var locationToDelete = await _shop_Context.Locations.FirstOrDefaultAsync(x => x.Id == location.Id);
                if (locationToDelete == null)
                    return false;
                _shop_Context.Locations.Remove(locationToDelete);
                return await CreateLocation(location, cancellationToken);
            } catch (DbUpdateException)
            {
                return false;
            }
        }
        public async Task<bool> DeleteLocation(Guid id, CancellationToken cancellationToken = default)
        {
            try
            {
                var locationToDelete = await _shop_Context.Locations.FindAsync(id);
                if (locationToDelete == null)
                    return false;
                _shop_Context.Locations.Remove(locationToDelete);
                return await _shop_Context.SaveChangesAsync(cancellationToken) > 0;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }
    }
}
