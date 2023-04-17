using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool isAdmin { get; set; }
        public List<ProductDTO> BoughtProducts { get; set; }
        public List<ProductDTO> ListedProducts { get; set; }
    }
}
