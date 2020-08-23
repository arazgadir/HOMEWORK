using System;
using System.Data;
using System.Linq;

namespace massiv
{
    class Program
    {
        static void Main(string[] args)


        {
            //int[] MyArray;

            //MyArray = new int[5];

            //MyArray[1] = 3;

            //int[] MyArray = new int[5];

            //int[] MyArray = new int[5] { 5, 9, 6, 4, 3 };

            //int []MyArray = new [5] { 5, 9, 6, 4, 3 };

            //int[] MyArray = { 5, 9, 6, 4, 3 };


            //  int[] MyArray = Enumerable.Repeat(5, 10).ToArray();   Массив из 10ти элементов,в каждом элементе 5ка  

            // int[] MyArray = Enumerable.Range(4, 5).ToArray();    Массив содержит 5 элементов , начиная с 4ки ( 4,5,6,7,8)





                                                                  //8 Посчитать количество нечетных элементов массива.



            int[] newarray = { 8, 3, 4, 40, 6, 23, 5, 7, 9 };

            int a = 0;                                                 // тут в конце будут храниться выходные данные 

            for (int i = 1; i < newarray.Length; i++)
            {

                int b = newarray[i];                                  // в переменной  --b-- хранятся элементы массива   --newarray--

                if (b % 2 != 0)

                    a = a + 1;                                       //  присваиваем к переменной   --a--КОЛИЧЕСТВО НЕЧЕТНЫХ элементов массива
            }

            Console.WriteLine(a);



        }
    }
}
