using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    interface IContract
    {
        void DoeMaarIets();
    }

    class ACME
    {
        private IContract[] werknemers = new IContract[10];

        public void Hire(IContract x)
        {
            for(int i = 0; i < werknemers.Length; i++)
            {
                if (werknemers[i] == null)
                {
                    werknemers[i] = x;
                    return;
                }
            }
        }

        public void Stoomfluit()
        {
            Console.WriteLine("ACME gaat produceren");
            foreach(IContract c in werknemers)
            {
                c?.DoeMaarIets();
            }
        }

    }
}
