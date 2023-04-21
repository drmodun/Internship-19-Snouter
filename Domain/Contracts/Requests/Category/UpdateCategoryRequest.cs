using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Requests.Category
{
    public class UpdateCategoryRequest
    {
        public Guid Id;
        public string Name;
        public string Description;
        public string Schema;
    }
}
