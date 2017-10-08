using System;

namespace Sem._1_Mannanova
{
    class Program
    {
        static void Main(string[] args)
        {
            //Условие: по длинам трёх отрезков определить могут ли отрезки являться сторонами треугольника (YES|NO)
            //стороны треугольника
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a>0 && b>0 && c>0)
            {
                if (a + b > c && a + c > b && b + c > a)
                    Console.WriteLine("Yes");

                else
                    Console.WriteLine("No");
            }
            Console.ReadKey();
        }
    }
}
