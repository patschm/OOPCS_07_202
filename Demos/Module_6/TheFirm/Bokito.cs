using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    class Bokito: IContract
    {
        public void DoeMaarIets()
        {
            Werkt();
        }

        public void Werkt()
        {
            Console.WriteLine("Bokito ramt dames in elkaar");
        }
    }
}
