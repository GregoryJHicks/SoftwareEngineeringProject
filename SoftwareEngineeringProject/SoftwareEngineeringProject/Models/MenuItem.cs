using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Models
{
    //take in selected items from FullMenu Linked List and turn it into objects that are sent to the cart
    public class MenuItem
    {
        public int food_id { get; set; }
        public string food_name { get; set; }
        public float price { get; set; }
        public string description { get; set; }

        
    }
}
