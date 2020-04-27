using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace superMarket2
{
    class addProduct
    {
        
        public void addp()
        {
            Console.Clear();
            checkNinsert(1, "mouse", 300, 50, 8.1);
            checkNinsert(2, "kboard", 600, 10, 8.3);
            checkNinsert(3, "monitor", 6000, 25, 7.3);
            checkNinsert(4, "HDD", 3500, 15, 8.4);
            checkNinsert(5, "RAM", 4000, 50, 9.3);

            //takeinput();

            Console.Write("Product added successfully.\n\nEnter 1 to add more product\n\nEnter 2 for Main menu.\n\nEnter: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1) addp();
            else
            {
                mainMenu ob = new mainMenu();
                ob.menu();
            }
        }

        public void takeinput()
        {
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

            checkNinsert(id, name, amount, quantity, rating);

        }

        public void checkNinsert(int id, string name, int amount, int quantity, double rating)
        {
            if (id > 0)
            {
                bool check = productList.plist.Exists(x => x.id == id);
                if (check == true)
                {
                    product obj = productList.plist.First(x => x.id == id);
                    if(obj.name != name)
                    {
                        Console.WriteLine("Produt Id & Name is not matched!!\nDo you want to update product name?");
                        Console.WriteLine("1. Update Product Name\n2. Add Product\n3. Main Menu");
                        Console.Write("Enter choice: ");
                        int aa = Convert.ToInt32(Console.ReadLine());
                        if(aa == 1)
                        {
                            obj.name = name;
                            obj.quantity = obj.quantity + quantity;
                            obj.amount = amount;
                            obj.rating = rating;
                        }
                        else if(aa == 2)
                        {
                            addp();
                        }
                        else
                        {
                            mainMenu menu = new mainMenu();
                            menu.menu();
                        }
                    }
                    else
                    {
                        obj.quantity = obj.quantity + quantity;
                        obj.amount = amount;
                        obj.rating = rating;
                    }
                    
                }
                else
                {
                    productList.proAdd(id, name, amount, quantity, rating);
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wrong input. Try again.");
                addp();
            }
        }

    }
}
