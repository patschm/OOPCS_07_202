using System;

namespace Willem
{
    class Program
    {
        static void Main(string[] args)
        {
            MathDel del = WetenschappersCERN.Add;
            del = del + WetenschappersCERN.Add;
            del = del + WetenschappersCERN.Subtract;
            //del = del - WetenschappersCERN.Add;
            //del = del - WetenschappersCERN.Subtract;

            foreach(var m in del.GetInvocationList())
            {
                Console.WriteLine(m.Method.Name);
            }
            //Console.WriteLine(del(1,2));


            WillemKlein wk = new WillemKlein();

            wk.Bereken(del, 1,2);



        }
    }
}
