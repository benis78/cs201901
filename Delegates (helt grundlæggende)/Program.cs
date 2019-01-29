using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace delegates_heltsimpel

{

    //public delegate void MinDelegate1(string t);

    



    class Program

    {

        static void Main(string[] args)

        {

            Action<String> f1 = MinSkrivTilConsole;

            f1("test");

            

            Action <String> f2 = MinSkrivTilConsole;

            f2("test");

            

            Action <String> f3 = MinSkrivTilConsole;

            f3 += Console.WriteLine;

            f3("test");

            

            f1 -= MinSkrivTilConsole;

            f2 -= MinSkrivTilConsole;

            f3 -= MinSkrivTilConsole;

            f3 -= Console.WriteLine;



        }



static void MinSkrivTilConsole(string txt)

{

    Console.WriteLine("**** " + txt + " ****");

}

    }

}