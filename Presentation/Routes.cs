using Domain;

namespace Presentation
{
    public static class Routes
    {
        private const string Base = "api";  
        public static class Location
        {
            public const string GetAll = Base + $"/locations";
            public const string Get = Base + $"/locations/{{id:Guid}}";
            public const string Create = Base + $"/locations";
            public const string Update = Base + $"/locations/{{id:Guid}}";
            public const string Delete = Base + $"/locations/{{id:Guid}}";
        }
        public static class User
        {
            public const string GetAll = Base + $"/users";
            public const string Get = Base + $"/users/{{id:Guid}}";
            public const string Create = Base + $"/users";
            public const string Update = Base + $"/users/{{id:Guid}}";
            public const string Delete = Base + $"/users/{{id:Guid}}";
        }
        public static class Category
        {
            public const string GetAll = Base + $"/categories";
            public const string Get = Base + $"/categories/{{id:Guid}}";
            public const string Create = Base + $"/categories";
            public const string Update = Base + $"/categories/{{id:Guid}}";
            public const string Delete = Base + $"/categories/{{id:Guid}}";
        }
        public static class SubCategory
        {
            public const string GetAll = Base + $"/subcategories";
            public const string Get = Base + $"/subcategories/{{id:Guid}}";
            public const string Create = Base + $"/subcategories";
            public const string Update = Base + $"/subcategories/{{id:Guid}}";
            public const string Delete = Base + $"/subcategories/{{id:Guid}}";
        }
        public static class Products
        {
            public const string GetAll = Base + $"/products";
            public const string Get = Base + $"/products/{{id:Guid}}";
            public const string Create = Base + $"/products";
            public const string Update = Base + $"/products/{{id:Guid}}";
            public const string Delete = Base + $"/products/{{id:Guid}}";
        }
        public static class BuyersProducts
        {
            public const string GetAll = Base + $"/buyersproducts";
            public const string Get = Base + $"/buyersproducts/{{id:Guid}}";
            public const string Create = Base + $"/buyersproducts";
            public const string Update = Base + $"/buyersproducts/{{id:Guid}}";
            public const string Delete = Base + $"/buyersproducts/{{id:Guid}}";
        }
        public static class Country
        {
            public const string GetAll = Base + $"/countries";
            public const string Get = Base + $"/countries/{{id:Guid}}";
            public const string Create = Base + $"/countries";
            public const string Update = Base + $"/countries/{{id:Guid}}";
            public const string Delete = Base + $"/countries/{{id:Guid}}";
        }
    }
}
