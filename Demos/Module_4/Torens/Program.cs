using System;

namespace Torens
{
    class Program
    {
        static void Main(string[] args)
        {
            Etage.Elevator.Call(34);

            Etage[] flat = new Etage[80];

            for(int i = 0; i < flat.Length; i++)
            {
                flat[i] = new Etage { EtageNummer = i };
            }


            flat[49].CallElevator();

            foreach(Etage et in flat)
            {
                //Console.WriteLine(et.EtageNummer);
                //et.DisplayElevator();
                Etage.DisplayElevator();
            }
        }
    }
}
