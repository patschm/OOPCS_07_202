using System;

namespace MoreInteraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Patrick p = new Patrick();
            Roelof r = new Roelof();
            // p.HaalDeLunch();

            DelNaam var1 = p.HaalDeLunch;
            var1();

            r.DoeIets(p.HaalDeLunch);
            r.DoeIets(Bla);
        }

        static void Bla()
        {
            Console.WriteLine("Blabla");
        }
    }
}
