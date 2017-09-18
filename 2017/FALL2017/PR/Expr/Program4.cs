using System;

namespace Expr._4_Mannanova
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());//натуральное число
            int x = Convert.ToInt32(Console.ReadLine());//простой делитель
            int y = Convert.ToInt32(Console.ReadLine());//простой делитель
            N = N - 1;
            x = (int)N/x + N/y - N/(x*y);//кол.-во делителей числа N-1
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
