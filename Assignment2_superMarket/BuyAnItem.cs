using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace superMarket2
{
    public class BuyAnItem
    {
        public void buy()
        {
            Console.WriteLine("Buy an Item");
            Console.WriteLine("..............");
            Console.Write("Enter product id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            product obj = productList.plist.First(x => x.id == id);
            if(obj != null)
            {
                obj.quantity = obj.quantity - quantity;

            }

            mainMenu o = new mainMenu();
            o.menu();
        }
    }
}
