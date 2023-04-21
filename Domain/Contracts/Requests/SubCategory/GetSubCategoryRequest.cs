using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Requests.SubCategory
{
    public class GetSubCategoryRequest
    {
        public Guid Id;
        public string? Slug;
    }
}
