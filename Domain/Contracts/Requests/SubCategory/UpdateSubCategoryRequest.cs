using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Requests.SubCategory
{
    public class UpdateSubCategoryRequest
    {
        public Guid Id;
        public string Name;
        public string Description;
        public Guid CategoryId;
        public string Schema;
    }
}
