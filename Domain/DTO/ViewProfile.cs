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
        public Location Location { get; set; }

        public ICollection<Product> Products { get; set; }

        public ICollection<BuyersProducts> BoughtProudcts;

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
