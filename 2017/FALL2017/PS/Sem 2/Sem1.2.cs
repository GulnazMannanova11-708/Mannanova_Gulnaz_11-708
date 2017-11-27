using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            double xn = 1;
            for (int i = 1; i <= k; i++)
                xn = xn * x / i;
            return (xn);
        }

        static int ToFindSum(double x)
        {
            int k = 1;
            double addVar = -1;
            double e = 0.0000000001;
            double sum = 0;
            while (Math.Abs(addVar - sum) > e)
            {
                addVar = sum;
                sum += Math.Pow(-1, k + 1) * ImplementheFormula(x, k);
                k++;
            }
            return (k-1);
        }
    }
}
