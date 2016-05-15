using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunnyNames
{
    class FunnyNames
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Writing the value of one variable");
            string name = "Bud Wiser";
            Console.WriteLine(name);

            string[] funnyNames = {"Justin Case", "Eileen Dover", "Dan D. Lyons",
                                      "Barb Dwyer", "Jean Poole", "Justin Time"};

            Console.WriteLine("\nWriting the elements of the array (While)");

            int i = 0;
            while (i < funnyNames.Length)
            {
                Console.WriteLine(funnyNames[i]);
                i = i + 1;
            }

            Console.WriteLine("\nWriting the elements in reverse order (For)");
            Array.Reverse(funnyNames);
            for (int j = 0; j < funnyNames.Length; j++)
            {
                if (funnyNames[j].ToLower() == "jean poole")
                    funnyNames[j] = "Lucy Fer";

                Console.WriteLine(funnyNames[j]);
            }

            Console.WriteLine("\nWriting the elements sorted (ForEach)");
            Array.Sort(funnyNames);

            foreach (string newName in funnyNames)
            {
                Console.WriteLine(newName);
            }

            Console.ReadKey();
        }
    }
}
