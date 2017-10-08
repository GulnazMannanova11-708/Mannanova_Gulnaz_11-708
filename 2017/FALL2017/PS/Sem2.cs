using System;

namespace Sem._2_Mannanova
{
    class Program
    {
        static void Main(string[] args)
        {
            //Условие: по двум первым членам арифметической прогрессии и числу k вычислить значение k-го члена
            //программма для нахождения K члена ариф. прогрессии;
            Console.WriteLine("Введите первый и второй член последовательности");
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер члена последовательности: ");
            int k = int.Parse(Console.ReadLine());
            int b; //на какое число увеличивается последовательность
            int ak;//значение К члена последовательности
            b = a2 - a1;
            ak = a1 + (k - 1) * b;
            Console.WriteLine("Значение этого члена ариф. прогрессии = " + ak);
            Console.ReadKey();
        }
    }
}
