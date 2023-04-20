using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Response.Subcategory
{
    public class GetAllSubcategoriesResponse
    {
        public List<SubCategoryDTO> SubCategories { get; set; }
    }
}
