using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Models
{
    public class Order
    {
        private const float TaxRate = .0696F; //This is the real tax rate for Georgia after including local sales tax

        public List<MenuItem> Contents = new List<MenuItem>();
        public int OrderId;
        public float SubTotal;
        public float Total;
        public bool Active;
        public DateTime TimeOfOrder;

        [Required]
        public string Address;
        [Required]
        public string Name;
        [Required]
        [StringLength(maximumLength:16,ErrorMessage = "That is not a valid card number", MinimumLength = 16)]
        public string CardNumber;


        public void ProcessOrder()
        {
            foreach (var item in Cart.Contents)
            {
                Contents.Add(item);
            }
            SubTotal = CalculateSubTotal();
            Total = CalculateTotal();
            Active = true;

            TimeOfOrder = DateTime.Now;

            Cart.ResetCart();
        }

        //public Order(string TempAddress, string TempName, string TempCardNumber)
        //{
        //    Contents = Cart.Contents;
        //    SubTotal = CalculateSubTotal();
        //    Total = CalculateTotal();
        //    Active = true;

        //    Address = TempAddress;
        //    Name = TempName;
        //    CardNumber = TempCardNumber;

        //    Cart.ResetCart();
        //}

        private float CalculateSubTotal()
        { 
            float count = 0.0F;
            foreach (var item in Contents)
            {
                count = count + item.price;
            }
            return count;
        }

        private float CalculateTotal()
        {
            return SubTotal + (SubTotal * TaxRate);
        }

        public double GetTaxRate()
        {
            return Convert.ToDouble(TaxRate) * 100;
        }
    }
}
