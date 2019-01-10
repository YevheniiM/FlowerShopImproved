using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop.flowers
{
    public class FlowerGroup
    {
        private Flower Flower;
        private int Quantity;

        public FlowerGroup(Flower flower, int quantity)
        {
            Flower = new Flower(flower);
            Quantity = quantity;
        }

        public double GetPrice()
        {
            return Flower.GetPrice() * Quantity;
        }
    }
}
