using System;

namespace TheFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            Patrick p = new Patrick();
            ACME comp = new ACME();
            IContract r = new Roelof();
            Bokito b = new Bokito();
            CodeOMatic co = new CodeOMatic();

            comp.Hire(p);
            comp.Hire(r);
            comp.Hire(b);

            comp.Stoomfluit();
        }
    }
}
