using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Models
{
    public static class Cart
    {
        public static List<MenuItem> Contents = new List<MenuItem>();
        public static void AddToCart(MenuItem item)
        {
            Contents.Add(item);
        }
        public static void ResetCart()
        {
            Contents.Clear();
        }
    }
}
