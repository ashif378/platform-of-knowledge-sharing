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
            bool a = productList.plist.Exists(z => z.id == x);

            if(a == true)
            {
                productList.plist.RemoveAll(p => p.id == x);
            }
            else
            {
                Console.WriteLine("\nProduct not found to be deleted.\n");
            }
            

            mainMenu ob = new mainMenu();
            ob.menu();
        }
    }
}
