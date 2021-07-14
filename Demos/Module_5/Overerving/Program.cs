using System;

namespace Overerving
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generaliseren
            Lamp t1 = new TL { Lumen = 300, StarterTijd = 400 };
           // ((TL)t1).StarterTijd = 200;

            t1.Aan();

            t1.Uit();
            //Lamp x = new Lamp();
            //x.Uit();
        }
    }
}
