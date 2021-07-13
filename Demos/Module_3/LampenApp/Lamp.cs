using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampenApp
{
    // Blauwdruk van een object
    class Lamp
    {
        // Field. Hierin slaan we eigenschappen van een object op,
        private int _lumen = 200;
        // private ConsoleColor _kleur = ConsoleColor.Yellow;

        // Old school. Zo doet een Javaan of C++ -er dat
        // Hieraan herkent men de zelfstudent.
        public void SetLumen(int lm)
        {
            if (lm >= 0 && lm < 1000)
            {
                _lumen = lm;
            }
        }
        public int GetLumen()
        {
            return _lumen;
        }

        // Properties. Hiermee geef je gecontroleerd toegang to de fields (Encapsulation)
        public int Lumen
        {
            get
            {
                return _lumen;
            }
            set
            {
                if (value >= 0 && value < 1000)
                {
                    _lumen = value;
                }
            }
        }
        // Auto Generating property
        public ConsoleColor Kleur { get; set; } = ConsoleColor.Yellow;


        // Gedrag. Leg je vast in methods
        public void Aan()
        {
            Console.BackgroundColor = Kleur;
            Console.WriteLine($"De lamp brandt met {Lumen} lumen");
        }
        public void Uit()
        {
            Console.WriteLine("De lamp gaat uit");
            Console.ResetColor();
        }

        // Constructor
        public Lamp(ConsoleColor color, int lumen)
        {
            Kleur = color;
            Lumen = lumen;
        }
        public Lamp()
        {

        }
    }

}
