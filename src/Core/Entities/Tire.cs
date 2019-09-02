using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Tire
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Producer { get; set; }
        public int WarrantyInYears { get; set; }
        public int VMax { get; set; }
    }
}
