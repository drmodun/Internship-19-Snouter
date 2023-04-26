using Domain.DTO;
using System.Net;

namespace Domain.Contracts.Response.Category
{
    public class UpdateCategoryReponse
    {
        public bool? Success { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public CategoryDTO? Category { get; set; }
    };
}
