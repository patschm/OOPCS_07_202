using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables();
            //Flows_1();
            //Flows_2();
            Flows_3();
          
        }

        private static void Flows_3()
        {
            int[] array1 = new int[10];
            array1[0] = 45;
            array1[1] = 55;

            Console.WriteLine(array1[1]);

            int[] array2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] array3 = { 1, 2, 3, 4, 5 };

            int[,] matrix = new int[3, 2] { { 0, 1 }, { 2, 3 }, { 4, 5 } };
            matrix[0, 0] = 45;
            matrix[2, 1] = 55;

           
        }

        private static void Flows_2()
        {
            // Als je niet precies weet hoe vaak je iets moet herhalen.
            // 1 of meer keer;
            do
            {

            }
            while (true);

            // Als je niet precies weet hoe vaak je iets moet herhalen.
            // 0 of meer keer;
            while(true)
            {

            }

            // Gebruik je alleen als je week hoe vaak je iets moet herhalen.
            int a = 0;
            for (Console.WriteLine("Init"); ; Console.WriteLine("End it"))
            {  
                a = a + 1;
                if (a == 5) continue;
                Console.WriteLine(a);
              
                if (a >= 10) break;
            }
        }

        private static void Flows_1()
        {
            int a = 2;

            switch(a)
            {
                case 0:
                case 1:
                    {
                        //...
                        break;
                    }
                case 2:
                    //...
                    break;
                default:
                    //...
                    break;
            }


            if(true)
            {
                //....
            }
            else
            {
                //...
            }
        }

        private static void Variables()
        {
            // TypeNaam variabelnaam
            uint age = 0;
            age += 20;
            Console.WriteLine(++age);

            int? leeftijd = null;

            int l1 = leeftijd ?? 0;
        }
    }
}
