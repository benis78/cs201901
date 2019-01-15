using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";

            string samletNavn = fornavn + " " + efternavn;

            Console.WriteLine(samletNavn);

            Console.WriteLine(samletNavn.ToUpper());

            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);

            Console.WriteLine(samletNavn.Substring(7,4));


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }



        }

}
}

