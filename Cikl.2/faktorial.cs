using System;

namespace Cikl._2
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Вычислить факториал числа n. n! = 1*2*…*n-1*n;!.


            //ulong start = 1;

            //ulong enter = ulong.Parse(Console.ReadLine());                  // введение числа 

            //for (ulong i = 1; i <= enter; i++)
            //    start *= i;

            //{

            //    Console.WriteLine("factorial= " + start);
            // }
            


            // FIBONACCI


            int a = 0;
            int b = 1;
            int c = 0;
           

            int[] fib = new int [30];

            for (int i = 0; i <fib.Length ; i++)
            {

                c = a + b;

                a = b;
                b = c;
                Console.WriteLine(b);
            }

            
        }
    }
}
