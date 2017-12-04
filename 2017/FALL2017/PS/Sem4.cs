using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem._4
{
    class Program
    {
        static void Main()
        {
            //Условие: На вход подаётся последовательность из n целых чисел (по модулю <=10^9). 
            //Определить является ли последовательность пилообразной 
            //(Чередуется возрастание/убывание a<b>c<d>e<f>g... 
            //Пример: 1 5 3 4 2 7 1 или 5 2 8 -1 9 0 3)

	    // ---check--- ваш алгоритм работает неправильно на последовательности с одинаковыми членами
            Console.Write("Введите количество чисел в последовательности: ");
            int amountOfNum = int.Parse(Console.ReadLine());
            int auxiliary;//присваиваем разность предыдущ. и этого числа
            bool correctFulfil = true;//переменная, которая овечает за выполнение условия
            int number;//число последовательности
            int assignment;//доп. переменная, в которую мы присваиваем предыдущее число последовательности

            number = int.Parse(Console.ReadLine());
            assignment = int.Parse(Console.ReadLine());
            if (assignment - number > 0) auxiliary = 1;
            else auxiliary = -1;

                for (int i = 0; i < amountOfNum - 2; i++)
            {
                number = int.Parse(Console.ReadLine());
                if ((number - assignment) * auxiliary > 0)//
                    correctFulfil = false;
                auxiliary = number - assignment;
                assignment = number;
            }

            if (!correctFulfil) Console.WriteLine("Не является пилообразной");
            else Console.WriteLine("Является пилообразной");

            Console.ReadKey();
        }
    }
}
