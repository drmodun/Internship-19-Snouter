using Data.Entities;
using Data.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class LocationRepo
    {
        private readonly ShopContext _shop_Context;

        public LocationRepo(ShopContext shop_Context)
        {
            _shop_Context = shop_Context;
        }
        public async Task<List<Location>> GetAllLocations()
        {
            return await _shop_Context.Locations.ToListAsync();
        }
        public async Task<Location> GetLocationById(Guid id)
        {
            return await _shop_Context.Locations.FindAsync(id);
        }
        public async Task<bool> CreateLocation(Location location)
        {
            await _shop_Context.Locations.AddAsync(location);
            return await _shop_Context.SaveChangesAsync() > 0;
        }
        public async Task<bool> UpdateLocation(Location location)
        {
            var locationToDelete = await _shop_Context.Locations.FirstOrDefaultAsync(x => x.Id == location.Id);
            if (locationToDelete == null)
                return false;
            _shop_Context.Locations.Remove(locationToDelete);
            await _shop_Context.Locations.AddAsync(location);
            return await _shop_Context.SaveChangesAsync() > 0;
        }
        public async Task<bool> DeleteLocation(Guid id)
        {
            var locationToDelete = await _shop_Context.Locations.FindAsync(id);
            if (locationToDelete == null)
                return false;
            _shop_Context.Locations.Remove(locationToDelete);
            return await _shop_Context.SaveChangesAsync() > 0;
            
        }
    }
}
