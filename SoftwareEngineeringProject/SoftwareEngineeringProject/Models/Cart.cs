using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Models
{
    //We used a static class for the cart to allow the program to access the cart from any point with little trouble.
    //This class has two methods, one to add an item to the cart, and one to reset it to an empty state.
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
