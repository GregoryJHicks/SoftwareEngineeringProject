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
        public bool Active;
        public DateTime TimeOfOrder;

        [DataType(DataType.Currency)]
        public decimal SubTotal;

        [DataType(DataType.Currency)]
        public decimal Total;

        [DataType(DataType.Currency)]
        public decimal AddedTax;

        public string Address;
        public string Name;
        public string CardNumber;
        public string ExperationDate;
        public string SecurityCode;


        public void ProcessOrder(string tempName, string tempAddress, string tempCardNumber, string tempExperationDate, string tempSecurityCode)
        {
            Name = tempName;
            Address = tempAddress;
            CardNumber = tempCardNumber;
            ExperationDate = tempExperationDate;
            SecurityCode = tempSecurityCode;
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

        private decimal CalculateSubTotal()
        { 
            decimal count = 0.00M;
            foreach (var item in Contents)
            {
                count = count + Convert.ToDecimal(item.price);
            }
            return count;
        }

        private decimal CalculateTotal()
        {
            AddedTax = SubTotal + Convert.ToDecimal(TaxRate);
            return SubTotal + AddedTax;
        }
    }
}
