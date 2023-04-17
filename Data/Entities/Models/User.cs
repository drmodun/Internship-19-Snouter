﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities.Models
{
    public class User
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }

        public bool isAdmin = false;

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<Product> BoughtProducts { get; set; }

        public List<Product> ListedProducts { get; set; }
    }
}
