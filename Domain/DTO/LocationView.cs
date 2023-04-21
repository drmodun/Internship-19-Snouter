using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class LocationView
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<ProductDTO> Products { get; set; }
        public CountryDTO Country { get; set; }
        public List<ViewProfile> Users { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

    }
}
