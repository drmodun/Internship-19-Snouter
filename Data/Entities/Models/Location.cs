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
        public int CountryId;
        public Country Country;
        public ICollection<Product> Products { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
