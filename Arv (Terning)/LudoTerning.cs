namespace ArvTerning
{
    partial class Program
    {
        public class LudoTerning : Terning
        {
            public bool ErGlobus()
            {
                return this.Værdi == 3;
            }
            public bool ErStjerne()
            {
                return this.Værdi == 5;
            }
            public LudoTerning() : base()
            {

            }
            public LudoTerning(int værdi) : base(værdi)
            {

            }
            public override void Skriv()
            {
                if (this.Værdi ==3)
                {
                    System.Console.WriteLine("[G]");

                    
                }
                else if (this.Værdi == 5)
                {
                    System.Console.WriteLine("[S]");
                }
                else
                {
                    base.Skriv();
                }

            }


            //public override void Skriv()

            //{

            //    switch (this.Værdi)

            //    {

            //        case 3:

            //            Console.WriteLine("[G]");

            //            break;

            //        case 5:

            //            Console.WriteLine("[S]");

            //            break;

            //        default:

            //            base.Skriv();

            //            break;

            //    }

            //}
        }
    }
}