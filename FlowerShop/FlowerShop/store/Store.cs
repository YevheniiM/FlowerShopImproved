using System;
using System.Collections.Generic;
using System.Text;
using FlowerShop.flowers;

namespace FlowerShop.store
{
    class Store
    {
        private List<FlowerBucket> flowerBuckets;

        public Store()
        {
            flowerBuckets = new List<FlowerBucket>();
        }

        public Store(List<FlowerBucket> flowerBuckets)
        {
            this.flowerBuckets = flowerBuckets;
        }

        public void AddBucket(FlowerBucket bucket)
        {
            this.flowerBuckets.Add(bucket);
        }

        public void DeleteBucket(int id)
        {
            flowerBuckets.Remove(flowerBuckets[id]);
        }

        internal FlowerBucket GetBucket(int id)
        {
            return flowerBuckets[id];
        }

        internal void Submit(Order order)
        {
            Console.WriteLine(String.Format("Order for {0} was submitted. Total price is {1}", order.user.Name, order.Price));
        }
    }
}
