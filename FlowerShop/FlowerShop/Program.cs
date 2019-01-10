using FlowerShop.flowers;
using FlowerShop.store;
using System;
using System.Collections.Generic;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            FlowerBucket bucketRosesAndTulips = new FlowerBucket(
                new List<FlowerGroup>(){
                    new FlowerGroup(new Rose(3.5, Color.Blue, Country.England), 10),
                    new FlowerGroup(new Tulip(1.5, Color.Green, Country.Italy), 5),
                });

            FlowerBucket bucketRoses = new FlowerBucket(
                new List<FlowerGroup>(){
                    new FlowerGroup(new Rose(5.0, Color.Green, Country.England), 20)
                    });

            FlowerBucket bucketTulips = new FlowerBucket(
                new List<FlowerGroup>(){
                    new FlowerGroup(new Tulip(10.0, Color.Red, Country.Ukraine), 30)
                    });


            Store store = new Store(new List<FlowerBucket>() { bucketRoses, bucketTulips });
            User user = new User("Oles");
            Order order = new Order(user);
            order.AddBucket(0, store);
            order.AddBucket(1, store);
            order.Submit(store);
        }
    }
}
