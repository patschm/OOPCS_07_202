using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreInteraction
{
    delegate void DelNaam();

    class Roelof
    {
        public void DoeIets(DelNaam funktie)
        {
            Console.WriteLine("Roelof doet het volgende:");
            funktie();

        }
    }
}
