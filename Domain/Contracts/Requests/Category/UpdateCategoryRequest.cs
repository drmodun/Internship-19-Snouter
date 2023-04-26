﻿namespace Domain.Contracts.Requests.Category
{
    public class UpdateCategoryRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Schema { get; set; }
    }
}
