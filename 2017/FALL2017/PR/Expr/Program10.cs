using System;

namespace Expr._10_Mannanova
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 5 == 0 || i % 3 == 0)//рассматриыавем те числа, которые делятся на 3 и 5
                {
                    sum += i;//находим их сумму
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
