using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Models
{
    //We used a static class to hold all orders made during the session to allow the program to access the cart from any point with little trouble.
    //This class has two methods, one to add an order to the list, and one to obtain the last item in the list.
    public static class AllOrders
    {
        public static List<Order> Orders = new List<Order>();

        public static void Add(Order temp)
        {
            Orders.Add(temp);
        }

        public static Order Last()
        {
            return Orders.LastOrDefault();
        }
    }
}
