using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeRadio
{
    delegate void ReceiveMethod(string s);

    class RadioStation
    {
        private  ReceiveMethod _subscribers;

        public event ReceiveMethod Subscribers
        {
            add
            {
                _subscribers += value;
            }
            remove
            {
                _subscribers -= value;
            }
        }

        public void Broadcast()
        {
            Console.WriteLine("We gaan in de lucht");
            _subscribers("Hallo Luisteraars!!");
        }
    }
}
