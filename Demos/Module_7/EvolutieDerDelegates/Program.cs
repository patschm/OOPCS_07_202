using System;

namespace EvolutieDerDelegates
{
    delegate int MathDel(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            // Framework 1.0/1.1
            MathDel d1 = new MathDel(Add);
            int result = d1(1, 2);

            // Framework 2.0
            MathDel d2 = Add;
            result = d2(2, 3);

            int c = 100;

            MathDel d3 = delegate (int a, int b)
            {
                return a + b + c;
            };
            result = d3(3, 4);

            // Framework 3.0
            MathDel d4 =  (a, b) => a + b;
            result = d4(4, 5);

            // Procedures
            Action<string> a1 = Console.WriteLine;

            // Functions
            Func<int, int, int> d5 = (a, b) => a - b;
            result = d5(5, 6);


            result = Subtract(9, 4);
            Console.WriteLine(result);
            a1(result.ToString());


            int Subtract(int a, int b)
            {
                return a - b + c;
            }
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
