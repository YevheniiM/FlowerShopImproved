using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop.payment
{
    public interface IPaymentStrategy
    {
        void Pay(int amount);
    }
}
