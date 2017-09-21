using System;

namespace Expr._12_Mannanova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите поочередно значения h, t, v, x ");
            double h;
            double t;
            double v;
            double x;
            double vSrednee;
            double tMax;
            double tMin;
           
            h = Convert.ToInt32(Console.ReadLine());
            t = Convert.ToInt32(Console.ReadLine());
            v = Convert.ToInt32(Console.ReadLine());
            x = Convert.ToInt32(Console.ReadLine());
            //Находим vсреднее, чтобы потом сравнить с ним х
            vSrednee = (double)h / t;
            if (vSrednee <= x)
            {
                tMax = h / x;//тк уши закладывает при x < v, 
                //а при v = x + 0,000000001 примерно равно самому х
                tMin = 0;
            }
            else
            {
                tMax = t;
                tMin = (h - x * t) / (v - x);
                //h = x * tMin + v(t - tMin) 
            }
            Console.WriteLine("tMax = " + tMax + ", tMin = " + tMin);
            Console.ReadKey();
        }
    }
}
