using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop.flowers
{
    class Rose: Flower
    {
        public String Name { get { return "rose"; } }
        public Rose(double price, string color, string country): base(price, color, country)
        {

        }
    }
}
