using System;

namespace Types
{
    enum Weekdays: long
    {
        Sunday = 1,
        Monday = 2,
        Tuesday = 4,
        Wednesday = 8,
        Thursday = 16,
        Friday = 32,
        Saturday = 64
    }

    class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek wd = DayOfWeek.Saturday;
            int dag = 7;
            Types.Weekdays day = Types.Weekdays.Thursday;
            //Weekdays day = (Weekdays)dag;
            Console.WriteLine(day);

        }
    }
}
