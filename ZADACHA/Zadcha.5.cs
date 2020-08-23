using System;

namespace ZADACHA
{
    class Program
    {
        static void Main(string[] args)
        {

           // Программа запрашивает 2 числа.Выводит на экран их частное.При попытке разделить на 0, говорит, что на ноль делить нельзя.


            Console.WriteLine("Write two numbers: ");

            double a = double.Parse(Console.ReadLine());

            double b = double.Parse(Console.ReadLine());

            switch (b)
            {
                case 0:

                    Console.WriteLine("you cannot divide by zero");
                    break;

            }

            double c = (a / b);

            Console.WriteLine(c);




        }
    }
}
