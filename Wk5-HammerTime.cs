using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HammerTime
{
    class HammerTime
    {
        static void Main(string[] args)
        {
            //declaration
            int orderNumber;
            string customerName;
            int deskInitial = 200;
            int deskFinal = 0;
            int deskLength;
            int deskWidth;
            int deskSize;
            int deskSizeOver = 50;
            int woodType;
            int woodMahogany = 150;
            int woodOak = 125;
            int deskDrawer;
            int drawerTotal;

            //input orderNumber
            Console.WriteLine("==============================================================");
            Console.WriteLine("== Welcome to HammerTime Desk Ordering Console for COP1000");
            Console.Write("== Please enter your order number (1-99999): ");
            orderNumber = Convert.ToInt32(Console.ReadLine());

            //input customerName
            Console.Write("== Please enter your full name (Last,First): ");
            customerName = Console.ReadLine();

            //greet customer and state initial price.
            Console.WriteLine("==============================================================");
            Console.WriteLine("== Order# {0} | Hello: {1}", orderNumber, customerName);
            Console.WriteLine("== Please note, our initial manufacturing fee is $200.");
            Console.WriteLine("== Upgrading from our standard Pine wood adds $125-150.");
            Console.WriteLine("== Desks larger than 750 square inches will add $50.");
            Console.WriteLine("== Additional drawers are $30 each. All prices USD.");
            Console.WriteLine("==============================================================");

            //input deskLength
            Console.Write("== Enter the desk length in square inches (1-999): ");
            deskLength = Convert.ToInt32(Console.ReadLine());

            //input deskWidth
            Console.Write("== Enter the desk width in square inches (1-999): ");
            deskWidth = Convert.ToInt32(Console.ReadLine());
            deskSize = Convert.ToInt32(deskLength * deskWidth);

            //output deskSize selected
            if (deskSize < 750)
                Console.WriteLine("== Size requested: {0} < 750 sq in. $0 added.", deskSize);
            else
                Console.WriteLine("== Size requested: {0} > 750 sq in. $50 added.", deskSize);

            //input woodType 1=Mahogany 2=Oak 3=Pine
            Console.WriteLine("== Select a type of wood for the desk.");
            Console.WriteLine("== Available: 1=Mahogany 2=Oak 3=Pine");
            Console.Write("== Please enter the wood type (1-3): ");
            woodType = Convert.ToInt32(Console.ReadLine());

            //calculate and output woodType selected
            if (woodType == 1)
                Console.WriteLine("== Mahogony selected, $150 added to total.");
            else if (woodType == 2)
                Console.WriteLine("== Oak selected, $125 added to total.");
            else if (woodType == 3)
                Console.WriteLine("== Pine selected, $0 added to total.");
                     
            //input and calculate deskDrawer variable                        
            Console.Write("== Please enter the amount of drawers for desk: ");
            deskDrawer = Convert.ToInt32(Console.ReadLine());
            drawerTotal = deskDrawer * 30;
            Console.WriteLine("== Drawers requested: {0}, {1:c} added to total", deskDrawer, drawerTotal);

            //calculate all possible user variables desk options
            if (deskSize < 750 && woodType == 3)
                deskFinal = deskInitial + drawerTotal;
            else if (deskSize < 750 && woodType == 2)
                deskFinal = deskInitial + woodOak + drawerTotal;
            else if (deskSize < 750 && woodType == 1)
                deskFinal = deskInitial + woodMahogany + drawerTotal;
            else if (deskSize > 750 && woodType == 3)
                deskFinal = deskInitial + deskSizeOver + drawerTotal;
            else if (deskSize > 750 && woodType == 2)
                deskFinal = deskInitial + deskSizeOver + woodOak + drawerTotal;
            else if (deskSize > 750 && woodType == 1)
                deskFinal = deskInitial + deskSizeOver + woodMahogany + drawerTotal;

            //output
            Console.WriteLine("==============================================================");
            Console.WriteLine("== HammerTime Invoice for Order# {0}:", orderNumber);
            Console.WriteLine("==============================================================");
            Console.WriteLine("== Client Name: {0}", customerName);
            Console.WriteLine("== Desk Size: {0} x {1} sq. in.", deskLength, deskWidth);
            Console.WriteLine("== Desk Parameters: {0} total sq. in.", deskSize);
            Console.WriteLine("== Desk Wood Type: {0}", woodType);
            Console.WriteLine("== Additional Drawers: {0}", deskDrawer);
            Console.WriteLine("==============================================================");
            Console.WriteLine("== Total amount due for Order# {0}: {1:c}", orderNumber, deskFinal);
            Console.WriteLine("==============================================================");
            Console.Write("== Thanks for buying HammerTime made in 'Merica products...");

            Console.ReadKey();




        }
    }
}
