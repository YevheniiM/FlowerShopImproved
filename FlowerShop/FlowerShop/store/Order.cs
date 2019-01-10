using FlowerShop.flowers;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop.store
{
    class Order
    {
        private List<FlowerBucket> buckets;
        public double Price { get; set; }
        public User user;

        public Order(User user)
        {
            this.user = user;
            Price = 0;
            buckets = new List<FlowerBucket>();
        }

        public void AddBucket(int id, Store store)
        {
            buckets.Add(store.GetBucket(id));
        }

        public void AddFlowers(Flower flower, int quantity)
        {
            buckets[buckets.Count - 1].AddFlowerGroup(new FlowerGroup(flower, quantity));
        }

        public void Submit(Store store)
        {
            foreach(var bucket in buckets)
            {
                Price += bucket.GetPrice();
            }
            store.Submit(this);
        }
    }
}
