using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Models
{
    public static class AllOrders
    {
        public static List<Order> Orders = new List<Order>();

        public static void AddToOrders(Order temp)
        {
            Orders.Add(temp);
        }
    }
}
