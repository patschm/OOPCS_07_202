using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    class Patrick: Persoon
    {
        public override void Werkt()
        {
            Programmeert();
        }
        public void Programmeert()
        {
            Console.WriteLine("Patrick flanst wat in elkaar");
        }
    }
}
