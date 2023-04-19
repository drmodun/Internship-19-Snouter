using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class LocationView
    {
        public int Id;
        public string Name;
        public List<ProductDTO> Products;
        public CountryDTO Country;
        public List<ViewProfile> Users;
        public decimal Latitude;
        public decimal Longitude;

    }
}
