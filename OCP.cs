using System;
using System.Collections.Generic;
using System.Text;

namespace Logistics
{
	// 7. Open/Closed Priciple

	// Violated: Every time a new payment type is added this "Pay" method must be modified.
	// Hence class is not closed for modification
	public class Payment
    {
        public void Pay(string paymentType, decimal amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine("Invalid input!");
            }
            if(paymentType == "UPI")
            {
                Console.WriteLine("UPI payment of ", amount, " processed");
            }
            else if(paymentType == "Card")
            {
				Console.WriteLine("Card payment of ", amount, " processed");
			}
            else
            {
				Console.WriteLine("Invalid payment type");
			}
        }
    }

	// Fixed: Now new payment methods can be added by creating new classes that implement IPayment 
	public interface IPayment
	{
		void Pay(decimal amount);
	}

	public class UpiPayment : IPayment
	{
		public void Pay(decimal amount)
		{
			Console.WriteLine("UPI payment of ", amount, " processed");
		}
	}

	public class CardPayment : IPayment
	{
		public void Pay(decimal amount)
		{
			Console.WriteLine("Card payment of ", amount, " processed");
		}
	}


}
