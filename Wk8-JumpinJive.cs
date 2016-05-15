using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JumpinJive
{
    class JumpinJive
    {
        static void Main(string[] args)
        {
            int sub;
            int itemsFound = 0;
            int itemsNotFound = 0;

            string item;
            string itemLower;
            //string[] itemName = { "Whipped cream", "Cinnamon", "Chocolate sauce", "Amaretto", "Irish whiskey" };
            string[] itemName = { "whipped cream", "cinnamon", "chocolate sauce", "amaretto", "irish whiskey" };
            double[] itemPrice = { 0.89, 0.25, 0.59, 1.50, 1.75 };
            double price = 0.00;
            double totalPrice = 2.00;
         
            string msgNo = "Sorry, we do not carry that.";

            Console.WriteLine("================================================");
            Console.WriteLine("Welcome to JumpinJive Coffee Program for COP1000");            
            Console.WriteLine("Our standard cup of coffee is $2.00.");
            Console.WriteLine("Please select from the available toppings:");
            Console.WriteLine("================================================");

                foreach (string info in itemName)
                Console.WriteLine(info);
  
            Console.WriteLine("================================================");            

            Console.Write("Enter item name (quit to exit): ");
            item = Convert.ToString(Console.ReadLine());
            item = item.ToLower();

            while (item != "quit")
            {
                sub = 0;                
                bool foundIt = false;
                while (sub < itemPrice.Length)
                {
                    if (itemName[sub] == item)
                    {
                        foundIt = true;
                        price = itemPrice[sub];                                                
                        break;
                    }
                    //sub = sub + 1;
                    sub++;
                }                

                if (foundIt)
                {
                    //Console.WriteLine(msgYes);                    
                    Console.WriteLine("{0} is {1:n} and has been added to your total.", item, price);
                    itemsFound = itemsFound + 1;
                    totalPrice = totalPrice + price;
                }
                else
                {
                    Console.WriteLine(msgNo);                    
                    itemsNotFound += 1;
                }

                Console.Write("Enter item name (quit to exit): ");
                item = Convert.ToString(Console.ReadLine());
                item = item.ToLower();
            }

            Console.WriteLine("JumpinJive topping added {1} toppings. Total price: {0:n}", totalPrice, itemsFound);            
            Console.ReadKey();
        }
    }
}
