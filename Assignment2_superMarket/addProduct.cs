using System;
using System.Collections.Generic;
using System.Text;

namespace superMarket2
{
    class addProduct
    {
        public void addp()
        {
            Console.Clear();
            productList.proAdd(1, "mouse", 300, 5, 8.1);
            productList.proAdd(2, "kboard", 600, 10, 8.3);
            productList.proAdd(3, "monitor", 6000, 25, 7.3);
            productList.proAdd(4, "HDD", 3500, 15, 8.4);
            productList.proAdd(5, "RAM", 4000, 50, 9.3);


            string name;
            int id, amount, quantity;
            double rating;

            Console.Write("Enter Product ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Product Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Product Price(1 unit): ");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Prodct Quantity: ");
            quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Product Rating: ");
            rating = Convert.ToDouble(Console.ReadLine());

            if(id > 0)
            {
                productList.proAdd(id, name, amount, quantity, rating);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wrong input. Try again.");
                addp();
            }
            

            Console.Write("Product added successfully.\n\nEnter 1 to add more product\n\nEnter 2 for Main menu.\n\nEnter: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1) addp();
            else
            {
                mainMenu ob = new mainMenu();
                ob.menu();
            }
        }
    }
}
