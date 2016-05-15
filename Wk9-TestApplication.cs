using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApplication
{
    class TestApplication
    {
        static void Main(string[] args)
        {

            int accountNum;
            double balance = 0;
            int year;
            string firstName;
            string lastName;
            double interestRate = 0.04;
            int term = 20;            

            Console.Write("Please enter account number (-1 to quit): ");
            accountNum = Convert.ToInt32(Console.ReadLine());
                       
                while (accountNum != -1)
            {
                Console.Write("Please enter first name: ");
                firstName = Convert.ToString(Console.ReadLine());

                Console.Write("Please enter last name: ");
                lastName = Convert.ToString(Console.ReadLine());

                Console.Write("Please enter initial deposit: ");
                balance = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Account#: {0} Name: {1} {2} Balance: {3}", accountNum, firstName, lastName, balance);

                year = 0;
                
                    while (year < term)
                {                  
                    balance = balance * (1 + interestRate);
                    year = year + 1;
                    Console.WriteLine("{0} \tBalance: {1:n}",year, balance);
                }
                                
                Console.Write("Press any key to enter another account number...");                
                Console.ReadKey();
                Console.Clear();

                Console.Write("Please enter account number (-1 to quit): ");
                accountNum = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
