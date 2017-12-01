using Solver;
using System;

namespace sem2
{
    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double k = ToFindSum(x);
            Console.WriteLine(k);
            Console.ReadKey();
        }

        static double ImplementheFormula(double x, int k)
        {
            //изначально считала циклом факториал и формулу,
            //но т.к.выходил за границу double, то в цикле for
            //возвожу в степень и делю на факториал сразу:
            double xn = 1;
            for (int i = 1; i <= (2 * k + 1); i++)
                xn = xn * x / i;
            return (xn);
        }

        static int ToFindSum(double x)
        {
            int k = 0;
            double addVar = -1;
            double e = 0.01;
            double sum = 0;
            while (sum - addVar > e)
            {
                addVar = sum;
                sum += ImplementheFormula(x, k);
                k++;
            }
            return (k);
        }
    }
}
