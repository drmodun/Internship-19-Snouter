using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities.Models;

namespace Domain.DTO
{
    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Images { get; set; }
        public Category Category { get; set; }
        public SubCategory SubCategory { get; set; }
        public UserDTO Seller { get; set; }
        public UserDTO Buyer { get; set; }
        public decimal Price { get; set; }
        public DateTime Created { get; set; }
        public int Quantity { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
}
