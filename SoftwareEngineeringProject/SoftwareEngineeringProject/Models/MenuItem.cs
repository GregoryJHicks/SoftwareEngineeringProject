using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Models
{
    //this class is used to make the objects that are put into the cart
    public class MenuItem
    {
        public int food_id { get; set; }
        public string food_name { get; set; }
        public decimal price { get; set; }
        public string description { get; set; }
    }
}
