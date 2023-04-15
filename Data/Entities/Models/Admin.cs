using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities.Models
{
    public class Admin : User
    {
        public List<IProduct> ProductsToManage { get; set; }
        public List<string> RightsList;
    }
}
