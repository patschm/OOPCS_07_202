using System;

namespace FuncProvesMeths
{
    class Program
    {
        static void Main(string[] args)
        {
            int aa;
            Inits(out aa);
            Console.WriteLine(aa);

            int a = 10;
            int b = 20;
            Console.WriteLine($"a={a}, b={b}");

            // int x = a
            Swap(ref a, ref b);
            Console.WriteLine($"a={a}, b={b}");

            float emmer = Telop(3.5F, 4F);

            int result = Telop(1, 2, 3, 4, 5 );

            emmer = Telop(b:8F);
            ShowNumber(emmer);
        }

        /// <summary>
        /// Initialiseert ints
        /// <code>
        ///  Code Sample
        /// </code>
        /// </summary>
        /// <param name="x">Geeft hier uw integer</param>
        static void Inits(out int x)
        {
            Console.WriteLine("Doet iets");
            x = 42;
        }

        static void Swap(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }

        // Procedure: Geeft niks terug
        // void NaamProcedure(int x, string y) {}
        static void ShowNumber(object nr)
        {
            Console.WriteLine($"Het getal is: {nr}");
        }

        // Function: Geeft altijd wat terug.
        // TypeName NaamFunction(TypeName name, TypeName name2) {}
        static int Telop(int a, int b)
        {
            int result = a + b;
            return result;
        }
        // Overload
        static float Telop(float a = 5F, float b = 10F)
        {
            float result = a + b;
            return result;
        }
        static int Telop(params int[] nrs)
        {
            int result = 0;
            for(int i = 0; i < nrs.Length; i++)
            {
                result += nrs[i];
            }
            return result;
        }
    }
}
