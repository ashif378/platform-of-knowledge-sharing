using System;
using System.Collections.Generic;
using System.Text;

namespace superMarket2
{
    public class product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int amount { get; set; }
        public int quantity { get; set; }
        public double rating { get; set; }

        public override string ToString()
        {
            return id + "\t" + name + "\t\t" + amount + "\t\t" + quantity + "\t\t" + rating;
        }

        public override int GetHashCode()
        {
            return id;
        }
    }
}
