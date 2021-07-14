using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    class Roelof: Persoon
    {
        public override void Werkt()
        {
            KanIets();
        }
        public void KanIets()
        {
            Console.WriteLine("Roelof doet iets slims");
        }
    }
}
