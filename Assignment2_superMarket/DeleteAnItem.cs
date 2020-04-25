using System;
using System.Collections.Generic;
using System.Text;

namespace superMarket2
{
    public class DeleteAnItem
    {
        public void delete()
        {
            Console.Write("\nEnter Id to delete a product: ");
            int x = Convert.ToInt32(Console.ReadLine());
            productList.plist.RemoveAll(p => p.id == x);

            mainMenu ob = new mainMenu();
            ob.menu();
        }
    }
}
