﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_variabeltal
{
    class Program
    {
        static void Main(string[] args)
        {
            int heltal = 10;
            heltal++;
            heltal--;
            heltal += 20;

            Console.WriteLine(heltal);

            double kommatal =12.5;
            kommatal++;
            kommatal--;
            kommatal*= 2;
            

            Console.WriteLine($"kommatal = {kommatal}");
       
            





            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }





        }


    }
}
