using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillPrinting
{
    class BillPrinting
    {
        static void Main(string[] args)
        {
            double balance = 500.00;
            double discountRate = 0.05;


            PrintBill(balance, discountRate);
            PrintBill(balance);
            PrintBill(balance, "Do shop with us again!");

            Console.ReadKey();
        }

        static void PrintBill(double balance, string message)
        {
            Console.WriteLine("Thank you for your order");
            Console.WriteLine(message);
            Console.WriteLine("Please remite {0:n}", balance);
        }

        static void PrintBill(double balance)
        {
            Console.WriteLine("Thank you for your order");
            Console.WriteLine("Please remit {0:n}", balance);
        }

        static void PrintBill(double balance, double discountRate)
        {
            double newBalance;
            double discount = balance * discountRate;
            newBalance = balance - discount;

            Console.WriteLine("Thank you for your order");
            Console.WriteLine("Your discount is {0:n}", discount);
            Console.WriteLine("Please remit {0:n}", newBalance);

        }
    }
}
