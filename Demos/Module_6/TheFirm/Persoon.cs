using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    class Persoon: IContract
    {
        public void DoeMaarIets()
        {
            Werkt();
        }

        public virtual void Werkt()
        {
            Console.WriteLine("Persoon doet iets");
        }
    }
}
