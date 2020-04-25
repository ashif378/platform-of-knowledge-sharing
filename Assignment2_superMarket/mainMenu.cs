using System;
using System.Collections.Generic;
using System.Text;

namespace superMarket2
{
    class mainMenu
    {
        public void menu()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Welcome To Super Market Shop Menu");
            Console.WriteLine("========================================");
            Console.WriteLine("\n1. Add Poduct Items\n2. Delete Items\n3. Buy an Item\n4. Show min and max Items based on Quantity\n5. Find an Item\n6. Print all Items\n7. Exit");

            Console.Write("\nEnter Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                addProduct ob1 = new addProduct();
                ob1.addp();
            }
            else if (choice == 2)
            {
                DeleteAnItem obj2 = new DeleteAnItem();
                obj2.delete();
            }
            else if (choice == 3)
            {
                BuyAnItem obj3 = new BuyAnItem();
                obj3.buy();
            }
            else if (choice == 4)
            {
                ShowMinMax obj4 = new ShowMinMax();
                obj4.show();
            }
            else if (choice == 5)
            {
                FindAnItem obj5 = new FindAnItem();
                obj5.find();
            }
            else if (choice == 6)
            {
                printAll ob6 = new printAll();
                ob6.print();
            }
            else if (choice == 7)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nWrong Ipnput. Please try againg...\n");
                menu();
            }
        }
    }
}
