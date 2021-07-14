using System;

namespace Torens
{
    class Lift
    {
        private int _current = 0;

        public int Current
        {
            get
            {
                return _current;
            }
        }
        public void Call(int etage)
        {
            Console.WriteLine("De Lift komt eraan");
            Console.WriteLine($"De lift is nu op de {etage} verdieping");
            _current = etage;
        }
    }
}