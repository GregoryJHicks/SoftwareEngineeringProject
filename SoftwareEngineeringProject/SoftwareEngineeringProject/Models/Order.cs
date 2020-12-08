using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Models
{
    public class Order
    {
        //This is the real tax rate for Georgia after including local sales tax
        private const float TaxRate = .0696F; 

        //These attributes are auto generated on initialization and do not need to be inputted
        public List<MenuItem> Contents = new List<MenuItem>();
        public int OrderId;
        public bool Active;
        public DateTime TimeOfOrder;

        //These attributes are different dollar amounts so we use data annotations to help format them corectly
        [DataType(DataType.Currency)]
        public decimal SubTotal;

        [DataType(DataType.Currency)]
        public decimal Total;

        [DataType(DataType.Currency)]
        public decimal AddedTax;

        //These attributes are required on initialization
        public string Address;
        public string Name;
        public string CardNumber;
        public string ExpirationDate;
        public string SecurityCode;


        public void ProcessOrder(string tempName, string tempAddress, string tempCardNumber, string tempExperationDate, string tempSecurityCode)
        {
            Name = tempName;
            Address = tempAddress;
            CardNumber = tempCardNumber;
            ExpirationDate = tempExperationDate;
            SecurityCode = tempSecurityCode;

            //We use a for loop to add all items from the cart to this order due to the program resetting both the cart and this orders contents when written as
            //this.Contents = Cart.Contents;
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

        //This method calculates the subtotal for the order
        private decimal CalculateSubTotal()
        { 
            decimal count = 0.00M;
            foreach (var item in Contents)
            {
                count = count + Convert.ToDecimal(item.price);
            }
            return count;
        }

        //This method calculates the overall total for the order
        private decimal CalculateTotal()
        {
            AddedTax = SubTotal * Convert.ToDecimal(TaxRate);
            return SubTotal + AddedTax;
        }
    }
}
