using System;
using System.Collections.Generic;
using System.Text;

namespace superMarket3
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int amount { get; set; }
        public int quantity { get; set; }
        public double rating { get; set; }

        public override string ToString()
        {
            return id + "\t" + name + "\t\t" + amount + "\t" + quantity + "\t" + rating;
        }

        public override int GetHashCode()
        {
            return id;
        }
    }
}
