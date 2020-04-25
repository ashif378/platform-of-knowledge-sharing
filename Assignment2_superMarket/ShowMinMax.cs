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
            int a = productList.plist.Max(x => x.quantity);
            //Console.WriteLine(a);
            int b = productList.plist.Min(x => x.quantity);
            //Console.WriteLine(b);

            product obj = productList.plist.First(x => x.quantity == a);
            Console.WriteLine(obj.id);

            product obj1 = productList.plist.First(y => y.quantity == b);
            Console.WriteLine(obj1.id);


            mainMenu ob = new mainMenu();
            ob.menu();
        }

    }
}
