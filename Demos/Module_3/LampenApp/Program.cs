
using System;

namespace LampenApp
{
  
    class Program
    {
        static void Main(string[] args)
        {
            // Hier begint de virtuele Wereld
            Lamp tl = new Lamp { Lumen = 900 };
            //tl.SetLumen(900);
            //tl.kleur = ConsoleColor.Yellow;
            //tl.lumen = 200;

            Lamp tl2 = new Lamp(ConsoleColor.Red, 350);
            tl2.Kleur = ConsoleColor.Green;
            //tl2._kleur = ConsoleColor.Red;
            //tl2._lumen = 300;

            tl.Aan();
            Console.WriteLine("Mooi man");
            tl.Uit();
            Console.WriteLine("Lezen in het donker");

            tl2.Aan();

            // Hier eindigt de virtuele wereld.
        }
    }
}
