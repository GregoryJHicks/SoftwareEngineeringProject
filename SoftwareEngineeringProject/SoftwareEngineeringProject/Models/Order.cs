using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Models
{
    public class Order
    {
        private const float TaxRate = .0696F; //This is the real tax rate for georgia after including local sales tax

        public List<MenuItem> Contents = new List<MenuItem>();
        public string Name;
        public List<string> Address = new List<string>();
        public int CardNumber;
        public int OrderId;
        public float SubTotal;
        public float Total;
        public bool Active;

        public Order()
        {
            Contents = Cart.Contents;
            SubTotal = CalculateSubTotal();
            Total = CalculateTotal();
            Active = true;

            Cart.ResetCart();
        }

        private float CalculateSubTotal()
        { 
            float count = 0.0F;
            foreach (var item in Contents)
            {
                count = +item.price;
            }
            return count;
        }

        private float CalculateTotal()
        {
            return SubTotal + (SubTotal * TaxRate);
        }
    }
}
