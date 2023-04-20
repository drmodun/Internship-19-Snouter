using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Requests.Category
{
    public class CreateCategoryRequest
    {
        public string Name;
        public string Description;
        public JSchema Schema;
    }
}
