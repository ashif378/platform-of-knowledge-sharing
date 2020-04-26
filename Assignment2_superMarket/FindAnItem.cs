using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace superMarket2
{
    public class FindAnItem
    {
        public void find()
        {
            Console.Write("Enter Prodct ID: ");
            int x = Convert.ToInt32(Console.ReadLine());

            bool a = productList.plist.Exists(z => z.id == x) ;
            
            if(a == true)
            {
                product obj = productList.plist.First(xx => xx.id == x);

                Console.WriteLine("\n\nId\tName\t\tAmount\t\tQuantity\tRating");
                Console.WriteLine(".....................................................................");
                Console.WriteLine($"{obj.id}\t{obj.name}\t\t{obj.amount}\t\t{obj.quantity}\t\t{obj.rating}");
            }
            else
            {
                Console.WriteLine("Produc Not Found!!");
            }
            mainMenu ob = new mainMenu();
            ob.menu();
        }
        

        
    }
}

