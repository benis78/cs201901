using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvTerning
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();

            t1.Skriv();
            t1.Ryst();
            t1.Skriv();


            LudoTerning l = new LudoTerning();

            l.Skriv();

            //Console.WriteLine($"Er Globus {l.ErGlobus()}");

            //Console.WriteLine($"Er Stjerne {l.ErStjerne()}");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}