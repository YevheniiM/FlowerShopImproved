using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop.flowers
{
    public class FlowerBucket
    {
        private List<FlowerGroup> flowerGroups;
        public static int GeneralId { private get; set; } = 0;
        public int ownId;

        public FlowerBucket()
        {
            flowerGroups = new List<FlowerGroup>();
            ownId = GeneralId++;
        }

        public FlowerBucket(List<FlowerGroup> flowerGroups)
        {
            this.flowerGroups = flowerGroups;
            ownId = GeneralId++;
        }

        public void AddFlowerGroup(FlowerGroup group)
        {
            flowerGroups.Add(group);
        }

        public double GetPrice()
        {
            double price = 0;
            foreach (var fl in flowerGroups)
                price += fl.GetPrice();
            return price;
        }
    }
}
