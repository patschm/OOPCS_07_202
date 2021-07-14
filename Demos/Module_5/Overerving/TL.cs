using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overerving
{
    // Overerving bevordert hergebruik van code.
    // Belangrijker: Geeft de mogelijkheid om te generaliseren.
    // Daarbij opent het de mogelijkheid om polymorfisme bloot te leggen. (virtual/override)
    class TL : Lamp
    {
        public int StarterTijd { get; set; } = 500;

        public override void Aan()
        { 
           Console.BackgroundColor = Kleur;
           for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Kuch kuch");
                Task.Delay(StarterTijd/4).Wait();
                Console.Clear();
            }
           
            Console.WriteLine($"De TL brandt met {Lumen} lumen");
        }
        public override void Uit()
        {
            Console.WriteLine("De TL gaat uit");
            Console.ResetColor();
        }
    }
}
