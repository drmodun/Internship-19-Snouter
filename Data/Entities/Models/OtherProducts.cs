using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities.Models
{
    public class OtherProducts : Product
    {
        public Dictionary<string, string> OtherProductProperties { get; set; }
    }
}
