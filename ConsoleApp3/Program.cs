using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 99; i++)

                

                Console.WriteLine(i);    

                if (System.Diagnostics.Debugger.IsAttached)
                {
                    Console.Write("Press any key to continue . . . ");
                    Console.ReadKey();
                }

            

        }
    }
}
