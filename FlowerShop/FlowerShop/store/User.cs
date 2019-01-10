using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop.store
{
    public class User
    {
        public static int GeneralId { private get; set; } = 0;
        private int Id { get; set; }
        public string Name { get; private set; }

        public User(String name)
        {
            Id = GeneralId++;
            this.Name = name;
        }

        public override string ToString()
        {
            return String.Format("The user {0} with id {1}", Name, Id);
        }
    }
}
