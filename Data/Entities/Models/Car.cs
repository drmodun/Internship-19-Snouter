using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities.Models
{
    public class Car : Product
    {
        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string HorsePower;

    }
}
