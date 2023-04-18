using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities.Models
{
    public class Location
    {
        public string Name;
        public int Id;
        public decimal Latitude;
        public decimal Longitude;
        public int CountryId;
        public Country Country;
        public ICollection<Product> Products { get; set; }
    }
}
