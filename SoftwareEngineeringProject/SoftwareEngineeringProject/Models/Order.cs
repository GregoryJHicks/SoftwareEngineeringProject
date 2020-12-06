using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Models
{
    public class Order
    {
        public List<MenuItem> Contents = new List<MenuItem>();
        public string Name;
        public List<string> Address = new List<string>();
        public int CardNumber;
        public int OrderId;
        public float Price;
        public bool Active;
    }
}
