using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RetailDiscount
{
    class RetailDiscount
    {
        static void Main(string[] args)
        {
            //declaration
            int itemsOrdered;
            double customerDiscount;
            int range1 = 10;
            int range2 = 24;
            int range3 = 50;
            int range4 = 0;
            double discount1 = 0.00;
            double discount2 = 0.10;
            double discount3 = 0.15;
            double discount4 = 0.20;

            Console.Write("Please enter number of items ordered: ");
            //gets confusing, allegedly
            itemsOrdered = Convert.ToInt32(Console.ReadKey());

            if (itemsOrdered <= range1)
            {
                customerDiscount = discount1;
            }
            else
            {
                if (itemsOrdered <= range2)
                {
                    customerDiscount = discount2;
                }
                else
                {
                    if (itemsOrdered <= range3)
                    {
                        customerDiscount = discount3;
                    }
                    else
                    {
                        if (itemsOrdered<=range4)
                        {
                            customerDiscount = discount4;
                        }
                    }
                }
            }



        }
    }
}
