using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop.payment
{
    class CashPayment : IPaymentStrategy
    {
        public void Pay(int amount)
        {
            Console.WriteLine("Paying " + amount + " in cash...");
        }
    }
}
