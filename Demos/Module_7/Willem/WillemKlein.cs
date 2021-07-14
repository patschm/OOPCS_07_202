using System;


namespace Willem
{
    delegate int MathDel(int a, int b);

    class WillemKlein
    {
        public void Bereken(MathDel calc, int a, int b)
        {
            Console.WriteLine("Willem gaat nu rekenen: ");
            int resultaat = calc(a, b);

            // Hier gaat Willem Rekenen


            Console.WriteLine($"Eureka! Het antwoord is {resultaat}");
        }
    }
}
