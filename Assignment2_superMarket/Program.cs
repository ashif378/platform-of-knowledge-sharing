using System;
using System.Collections.Generic;
using System.Text;

namespace superMarket3
{
    class Program
    {
        static List<Product> plist = new List<Product>();
        
        public static void Main(string[] args)
        {
            mainMenu();
        }

        static void mainMenu()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Welcome To Super Market Shop Menu");
            Console.WriteLine("========================================");
            Console.WriteLine("\n1. Add Poduct Items\n2. Delete Items\n3. Buy an Item\n4. Show min and max Items based on Quantity\n5. Find an Item\n6. Print all Items\n7. Exit");

            Console.Write("\nEnter Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                addProduct();
            }
            else if (choice == 2)
            {
                deleteProduct();
            }
            else if (choice == 3)
            {

            }
            else if (choice == 4)
            {

            }
            else if (choice == 5)
            {

            }
            else if (choice == 6)
            {
                PrintAllItem();
            }
            else if (choice == 7)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nWrong Ipnput. Please try againg...\n");
                mainMenu();
            }
        }

        static void addProduct()
        {
            string name;
            int id, amount, quantity;
            double rating;

            plist.Add(new Product() { id = 1, name = "Mouse", amount = 250, quantity = 10, rating = 8.0 });
            plist.Add(new Product() { id = 2, name = "Monitor", amount = 5000, quantity = 7, rating = 9.5 });
            plist.Add(new Product() { id = 3, name = "Kboard", amount = 500, quantity = 13, rating = 8.0 });
            plist.Add(new Product() { id = 4, name = "RAM", amount = 3500, quantity = 23, rating = 9.3 });
            plist.Add(new Product() { id = 5, name = "HDD", amount = 3600, quantity = 17, rating = 9.7 });

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


            plist.Add(new Product() { id = id, name = name, amount = amount, quantity = quantity, rating = rating });


            Console.WriteLine("Product Added successfully.");

            

            mainMenu();
        }

        static void deleteProduct()
        {
            Console.WriteLine("Id\tName\t\tPrice\tQuantity\tRating");
            foreach (Product a in plist)
            {
                Console.WriteLine(a);
            }


            Console.Write("\nEnter Id to delete a product: ");
            int x = Convert.ToInt32(Console.ReadLine());
            plist.RemoveAll(p => p.id == x);

            mainMenu();
        }

        static void buyItem()
        {

        }

        static void showItemByMinMax()
        {

        }

        static void findItem()
        {

        }

        static void PrintAllItem()
        {
            Console.WriteLine("Id\tName\t\tPrice\tQuantity\tRating");
            foreach (Product a in plist)
            {
                //Console.WriteLine($"{a.id} {a.name}");
                Console.WriteLine(a);
            }
            mainMenu();
        }

        static void exitProgram()
        {
            Environment.Exit(0);
        }
        
    }
}
