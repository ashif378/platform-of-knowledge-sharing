using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace superMarket2
{
    public class ShowMinMax
    {
        public void show()
        {

            if(productList.plist.Count > 1)
            {
                int max = productList.plist.Max(x => x.quantity);
                //Console.WriteLine(max);
                int min = productList.plist.Min(x => x.quantity);
                //Console.WriteLine(min);

                product obj = productList.plist.First(x => x.quantity == max);
                product obj1 = productList.plist.First(y => y.quantity == min);


                Console.WriteLine($"Maximum Quantity Product: {obj.name}");
                Console.WriteLine($"Minimum Quantity Product: {obj1.name}");

                Console.WriteLine("Id\tName\t\tAmount\t\tQuantity\tRating");
                Console.WriteLine(".............................................................................");

                Console.WriteLine($"{obj.id}\t{obj.name}\t\t{obj.amount}\t\t{obj.quantity}\t\t{obj.rating}");
                Console.WriteLine($"{obj1.id}\t{obj1.name}\t\t{obj1.amount}\t\t{obj1.quantity}\t\t{obj1.rating}");
            }
            else if(productList.plist.Count == 1)
            {
                Console.WriteLine("\nOnly one product found.\n");
                printAll print = new printAll();
                print.print();
            }
            else 
            {
                Console.WriteLine("\nProduct list is empty!! \n\n");
            }
            
            mainMenu ob = new mainMenu();
            ob.menu();
        }

    }
}
