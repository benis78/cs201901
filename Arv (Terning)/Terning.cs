using System;

namespace ArvTerning
{
    public class Terning
    {

        private int _værdi;
        private static System.Random rnd;

        static Terning()
        {
            rnd = new Random();
        }

        public void Ryst()
        {
            Værdi = rnd.Next(1, 7);

        }

        public Terning()
        {
            Ryst();
        }

        public virtual void Skriv()
        {
            Console.WriteLine($"[{Værdi}]");
        }

        public Terning(int værdi)
        {
            Værdi = værdi;
        }

        public int Værdi
        {
            get
            {
                // .....
                // .....
                return _værdi;
            }
            set
            {
                // log
                // 
                if (value <= 0 || value > 6)
                    throw new ApplicationException("Forkert terning");
                this._værdi = value;
            }
        }
    }
}
