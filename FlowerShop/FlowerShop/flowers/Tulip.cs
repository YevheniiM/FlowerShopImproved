using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop.flowers
{
    class Tulip: Flower
    {
        public String Name { get { return "tulip"; } }
        public Tulip(double price, string color, string country): base(price, color, country)
        {

        }
    }
}
