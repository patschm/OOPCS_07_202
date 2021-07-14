using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Generieken
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lijsten();

            Point<long> p1 = new Point<long> { Y = 20, X = 30 };
            Console.WriteLine(p1);
            DoeIets(p1);
            Console.WriteLine(p1);


            float a = 10;
            float b = 20;
            //Console.WriteLine($"a={a}, b={b}");
            Swap<float>(ref a, ref b);
            //Console.WriteLine($"a={a}, b={b}");


           //var iets = new Func<List<string>, Action<Task<string>>>();
        }

        private static void DoeIets(Point<long> px)
        {
            px.X = 100;
            px.Y = 200;
        }

        private static void Lijsten()
        {
            ArrayList lisst2 = new ArrayList();
            lisst2.Add(5);

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);


            foreach(int x in list)
            {
                Console.WriteLine(x);
            }

            Stack<long> st = new Stack<long>();
            Queue<float> q = new Queue<float>();
            Dictionary<string, int> lookup = new Dictionary<string, int>();
            lookup.Add("een", 1);
            lookup.Add("twee", 2);

            Console.WriteLine(lookup["twee"]);
        }

        //static void Swap(ref int a, ref int b)
        //{
        //    int tmp = a;
        //    a = b;
        //    b = tmp;
        //}
        //static void Swap(ref double a, ref double b)
        //{
        //    double tmp = a;
        //    a = b;
        //    b = tmp;
        //}
        //static void Swap(ref float a, ref float b)
        //{
        //    float tmp = a;
        //    a = b;
        //    b = tmp;
        //}
        //static void Swap(ref long a, ref long b)
        //{
        //    long tmp = a;
        //    a = b;
        //    b = tmp;
        //}
        static void Swap<PL>(ref PL a, ref PL b) where PL: IFormattable
        {
            PL tmp = a;
            a = b;
            b = tmp;
        }
    }
}
