using System;
using System.Collections.Generic;
using System.Text;

namespace superMarket2
{
    public static class productList
    {

        public static List<product> plist = new List<product>();

        public static void proAdd(int id, string name, int amount, int quantity, double rating)
        {
            plist.Add(new product() { id = id, name = name, amount = amount, quantity = quantity, rating = rating });
        }

        public static void printList()
        {
            foreach (product a in plist)
            {
                Console.WriteLine(a);
            }
        }
    }
}
