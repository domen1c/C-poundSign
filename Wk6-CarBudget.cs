using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarBudget
{
    class CarBudget
    {
        static void Main(string[] args)
        {
            int accountNumber;
            string customerName;

            double balance = 0;
            double purchasePrice;
            double payment;

            Console.WriteLine("Welcome to Car Budget Monthly for COP1000");
            Console.Write("Please enter account number (-1 to quit): ");
            accountNumber = Convert.ToInt32(Console.ReadLine());                       

            while (accountNumber != -1)
            {
                Console.Write("Please enter account name: ");
                customerName = Convert.ToString(Console.ReadLine());

                Console.Write("Please enter purchase price of vehicle: ");
                purchasePrice = Convert.ToDouble(Console.ReadLine());

                balance = purchasePrice;

                Console.WriteLine("Account#: {0} Name: {1}", accountNumber, customerName);

                for (int month = 1; month <= 24; month++)
                {                    
                    payment = purchasePrice / 24;
                    balance = balance - payment;                    
                    Console.WriteLine("{0} \tBalance: {1:n}", month, balance);
                }
                                
                Console.Write("Press any key to enter another account number...");                
                Console.ReadKey();
                Console.Clear();

                Console.Write("Please enter account number (-1 to quit): ");
                accountNumber = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
