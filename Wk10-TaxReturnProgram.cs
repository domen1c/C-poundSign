using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxReturnProgram
{
    class TaxReturnProgram
    {
        static void Main(string[] args)
        {
            int balance = 500;
            double rate = 0.15;
            double tax;
            double taxAmount;

            //tax = CalculateTax(200,0.01); test it out!
            tax = CalculateTax(balance, rate);
            taxAmount = CalculateTax(balance, rate) * 0.05;

            //formatting n=number p=percentage c=dollarSign
            Console.WriteLine("Amount: {0:n} \tRate: {1:p} \tTax: {2:c}", balance, rate, tax);

            Console.WriteLine("Amount: {0:n} \tRate: {1:p} \tTax: {2:c}", 7000, 0.02,
                CalculateTax(7000, 0.02));

            //to get the guy up front to shut up:
            Console.WriteLine(GetName().ToUpper() + "abcd");
            string name = "Eileen Dover";
            Console.WriteLine(name);

            Console.ReadKey();

        }

        static double CalculateTax(int amount, double rate)
        {
            //one way to do it
            //double tax;
            //tax = amount * rate;
            //return tax;

            //another way
            return amount * rate;
        }

        static string GetName()
        {
            return "Ben Dover";                    
        }
    }
}
