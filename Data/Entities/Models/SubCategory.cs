﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public string Description { get; set; }

        public int MainCategoryId;
        public Category? MainCategory;
        public ICollection<ProductsSubCategories> ProductsSubCategories;

        public Dictionary<string, Type> SubPropertyNames { get; set; }
        public Dictionary<string, object> SubProperties { get; set; }

    }
}