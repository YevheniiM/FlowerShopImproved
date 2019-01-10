using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop.flowers
{
    public class Flower
    {
        private FlowerProperties FlowerProperties;

        public Flower()
        {
            FlowerProperties = new FlowerProperties();
        }

        public Flower(double price, string color, string country)
        {
            FlowerProperties = new FlowerProperties
            {
                Color = color,
                Price = price,
                Country = country
            };
        }

        public Flower(Flower flower)
        {
            FlowerProperties = new FlowerProperties
            {
                Color = flower.GetColor(),
                Price = flower.GetPrice(),
                Country = flower.GetCoutry()
            };
        }

        public string GetColor()
        {
            return FlowerProperties.Color;
        }

        public double GetPrice()
        {
            return FlowerProperties.Price;
        }

        public string GetCoutry()
        {
            return FlowerProperties.Country;
        }
    }
}
