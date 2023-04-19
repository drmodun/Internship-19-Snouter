using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities.Models;

namespace Domain.DTO
{
    public class ViewProfile
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email;
        public LocationView Location { get; set; }

        public List<ProductDTO> Products { get; set; }

        public List<BuyersProductsView> BoughtProudcts;

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
