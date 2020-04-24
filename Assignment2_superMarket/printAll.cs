using System;
using System.Collections.Generic;
using System.Text;

namespace superMarket2
{
    public class printAll
    {
        public void print()
        {
            Console.WriteLine("Id\tName\t\tAmount\t\tQuantity\tRating");
            Console.WriteLine(".............................................................................");

            productList.printList();

            mainMenu ob = new mainMenu();
            ob.menu();

        }
    }
}
