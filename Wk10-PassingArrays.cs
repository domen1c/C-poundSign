using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PassingArrays
{
    class PassingArrays
    {
        static void Main(string[] args)
        {
            //professor used the name "Mike Hunt" then realized and erased it. Priceless!
            string[] funnyNames = { "Barb Dwyer", "Art E. Choke", "Justin Time", "Jean Poole" };            
            PrintArray(funnyNames);
            Console.WriteLine();

            for (int i = 0; i < funnyNames.Length; i++)
                Console.WriteLine(funnyNames[i]);

            string[] moreNames = { "Jim Shoo", "Paige Turner", "Anna Conda", };
            Console.WriteLine();
            PrintArray(moreNames);

            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            PrintArray(numbers);

            Console.ReadKey();
        }

        static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            Console.WriteLine(array[i]);

            //assigning this array a new name
            array[2] = "Dan D. Lyons";
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }
    }
}
