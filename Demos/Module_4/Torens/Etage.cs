using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torens
{
    class Etage
    {
        public int EtageNummer { get; set; }
        public static Lift Elevator = new Lift();

        public void CallElevator()
        {
            Etage.Elevator.Call(EtageNummer);
        }
        public static void DisplayElevator()
        {
            Console.WriteLine($"De lift staat nu op de {Elevator.Current}");
        }
    }
}
