using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber__fuld_egenskab_
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person() { Fornavn = "jesper", Efternavn = "Hansen" };
            Person p2 = new Person() { Fornavn = "Toke" };

            Elev e1 = new Elev() { Fornavn = "Egon", Efternavn = "Nørd", Klasselokale=34};
            Instruktør i1 = new Instruktør() { Fornavn = "Ivan", Efternavn = "Intens"};

            int e2 =e1.Klasselokale;

            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(e1.FuldtNavn());
            Console.WriteLine(e2);
            Console.WriteLine(i1.FuldtNavn());



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        class Person
        {
            public String Fornavn { get; set; }
            public String Efternavn { get; set; }

            public String FuldtNavn()
            {
                return $"{Fornavn} {Efternavn}";

            }
        }

        class Elev : Person
        {
            public int Klasselokale { get; set; }

        }

        class Instruktør : Person
        {
            public int NøgleId { get; set; }
        }
    }
    //class Program

    //{

    //    static void Main(string[] args)

    //    {

    //        Person p = new Person() { Efternavn = "x", Fornavn = "y" };

    //        Elev e = new Elev() { Efternavn = "t", Fornavn = "g", KlasseLokale = "A" };

    //        Instruktør i = new Instruktør() { Efternavn = "2", Fornavn = "s", NøgleId = 1 };

    //        Console.WriteLine(p.FuldtNavn());

    //        Console.WriteLine(e.FuldtNavn());

    //        Console.WriteLine(i.FuldtNavn());

    //        // Hold console åben ved debug

    //        if (System.Diagnostics.Debugger.IsAttached)

    //        {

    //            Console.Write("Press any key to continue . . . ");

    //            Console.ReadKey();

    //        }

    //    }

    //}



    //public class Person

    //{

    //    public string Fornavn { get; set; }

    //    public string Efternavn { get; set; }

    //    public string FuldtNavn()

    //    {

    //        return $"{Fornavn} {Efternavn}";

    //    }



    //}



    //public class Elev : Person

    //{

    //    public string KlasseLokale { get; set; }

    //}



    //public class Instruktør : Person

    //{

    //    public int NøgleId { get; set; }

    //}


}
