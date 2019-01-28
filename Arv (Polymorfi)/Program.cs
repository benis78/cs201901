using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvPolymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            Faktura f1 = new Faktura() { Nr = 7, Dato = DateTime.Now.Date, Kunde = "Acme" };
            Console.WriteLine(f1);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }

        public class Faktura
        {
            public int Nr { get; set; }

            public DateTime Dato { get; set; }

            public String Kunde { get; set; }

            public override string ToString()
            {
                return $"Faktura til {Kunde} fra {Dato} nr{Nr}";
            }
        }

        
    }


}
