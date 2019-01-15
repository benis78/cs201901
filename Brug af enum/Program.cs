using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brug_af_enum
{
    class Program
    {
        static void Main(string[] args)
        {


            int kort1Værdi = 2;

            KortKulør kort1Kulør = KortKulør.hjerter;



            // Skriver værdi og nummer ud

            Console.WriteLine(kort1Kulør.ToString());

            Console.WriteLine((int)kort1Kulør);

            Console.WriteLine(kort1Værdi);

            int kort2Værdi = 2;

            KortKulør kort2Kulør = KortKulør.ruder;

            Console.WriteLine(kort2Kulør);
            Console.WriteLine(kort2Værdi);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }



}


