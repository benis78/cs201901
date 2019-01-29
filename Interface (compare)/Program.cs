using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[5];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 5, Navn = "snubbi" };
            hunde[2] = new Hund() { Alder = 3, Navn = "klat" };
            hunde[3] = new Hund() { Alder = 34, Navn = "Pøls" };
            hunde[4] = new Hund() { Alder = 2, Navn = "freddi" };
            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn +" "+ item.Alder);

    
            }

            

                if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Hund:IComparable<Hund>
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(Hund other)
        {
            return this.Alder.CompareTo(other.Alder);
        }
    }
}