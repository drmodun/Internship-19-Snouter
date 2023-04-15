using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities.Models
{
    public class ComputerProduct : Product
    {
        public string Processor { get; set; }
        public string Memory { get; set; }
        public string Storage { get; set; }
        public string Graphics { get; set; }
    }
}
