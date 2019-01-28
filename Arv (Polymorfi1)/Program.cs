using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv__Polymorfi1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund h1 = new Hund() {Navn = "Fido" };
            h1._Navn();

            Kat k1 = new Kat() { Navn = "misser" };
            k1._Navn();

            Dyr d1 = new Hund() { Navn = "fede" };
            d1._Navn();

            Console.WriteLine();
            List<Dyr> forskelligeDyr = new List<Dyr>() { h1, k1, new Hund() { Navn = "c" }, new Kat() { Navn = "d" } };
            foreach (Dyr item in forskelligeDyr)
            {
                item._Navn();
            }
            Console.WriteLine();

            Dyr[] dyr = new Dyr[20];

            for (int i = 0; i < 20; i++)
            {
                dyr[i] = Dyr.TilfældigtDyr();
            }

            foreach (var item in dyr)
            {
                item._Navn();
            }


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        abstract class Dyr
        {
            static System.Random rnd = new Random();
            public String Navn { get; set; }
            public virtual void _Navn()
            {
                Console.WriteLine("Jeg er et dyr og hedder "+Navn);
            }
            public static Dyr TilfældigtDyr()

            {



                string data = "Freja;Bella;Emma;Mille;Fie;Molly;Lady;Trine;Trunte;Luna;Amanda;";

                data += "Bonnie;Laika;Ronja;Sally;Trille;Zita;Tøsen;Bianca;Zenta;Victor;Buller;";

                data += "Buster;King;Simba;Thor;Charlie;Samson;Bamse;Mickey;Max;Rasmus;Sofus;Anton;";

                data += "Laban;Basse;Bølle;Oliver;Oscar;Balder";

                string[] navne = data.Split(';'); int index = rnd.Next(0, navne.Length);

                if (index % 2 == 0)

                {

                    return new Hund() { Navn = navne[index] };

                }

                else

                {

                    return new Kat() { Navn = navne[index] };

                }

            }
        }

        class Hund : Dyr
        {
            public override void _Navn()
            {
                Console.WriteLine("Jeg er en hund og hedder " + Navn);
            }
        }
        class Kat:Dyr
        {
            public override void _Navn()
            {
                Console.WriteLine("Jeg er en Kat og hedder " + Navn);
            }
        }

    }
}
