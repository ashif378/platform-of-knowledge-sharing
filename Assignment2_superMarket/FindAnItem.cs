using System;
using System.Collections.Generic;
using System.Text;

namespace superMarket2
{
    public class FindAnItem
    {
        public void find()
        {
            bool a = productList.plist.Exists(x => x.id == 2) ;
            Console.WriteLine(a);

            int v = productList.plist.FindIndex(x => x.id == 2);
            Console.WriteLine(v);

            mainMenu ob = new mainMenu();
            ob.menu();
        }
        

        
    }
}

