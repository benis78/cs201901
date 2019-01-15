﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d1;
            d1 = DateTime.Now;

            d1 = d1.AddDays(10);

            Console.WriteLine(d1);

            Console.WriteLine(d1.AddMinutes(20));

            Console.WriteLine(d1.AddMonths(-1));

            DateTime d2;
            d2 = new DateTime(2018,07,21);

            DateTime d3;
            d3 = new DateTime(2018, 11, 27);

            TimeSpan t1 = d3.Subtract(d2);

            Console.WriteLine($"Forskel mellem d3 og d2 i dage = {t1.TotalDays}");

            TimeSpan t2 = new TimeSpan(16, 0, 0);
            Console.WriteLine(t2);

            TimeSpan t3 = new TimeSpan(00, 30, 00);
            Console.WriteLine(t3);

            TimeSpan t4 = t2 - t3;
            Console.WriteLine(t4);

            TimeSpan t5 = t2 + t3;
            Console.WriteLine(t5);
        






            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }


        }
    }
}
