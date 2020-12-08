using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Models
{
    
    public class MenuItem
    {
        public int food_id { get; set; }
        public string food_name { get; set; }
        public decimal price { get; set; }
        public string description { get; set; }
    }
}
