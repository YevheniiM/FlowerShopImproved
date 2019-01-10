using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop.payment
{
    public class CreditCardPayment: IPaymentStrategy
    {
        public int Cvv { get; set; }
        public String CardNumber { get; set; }
        public DateTime Date { get; set; }

        public CreditCardPayment(int cvv, String cardNumber, DateTime date)
        {
            Cvv = cvv;
            CardNumber = cardNumber;
            Date = date;
        }

        public void Pay(int amount)
        {
            Console.WriteLine("Paying " + amount + " by card...");
        }
    }
}
