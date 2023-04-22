using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities.Models
{
    public class Location
    {
        public string Name;
        public Guid Id;
        public decimal Latitude;
        public decimal Longitude;
        public Guid CountryId;
        public Country? Country;
        public ICollection<Product> Products { get; set; } = new List<Product>();
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
