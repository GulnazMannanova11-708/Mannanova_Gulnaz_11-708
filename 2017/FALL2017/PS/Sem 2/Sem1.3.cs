using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem_2._1._3
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

		// ---check--- убирайте из кода ненужные комментарии
       /* static double ImplementheFormula(double x, int k)
        {
            double xn = 1;
            for (int i = 1; i <= 2*k; i++)
                xn = xn * x * 2 / i;
            return (xn);
        }

        static double ToFindSum(double x)
        {
            int k = 1;
            double addVar = -1;
            double e = 0.0000000001;
            double sum = 1;
            while (Math.Abs(addVar - sum) > e)
            {
                addVar = sum;
                sum += (Math.Pow(-1, k) * ImplementheFormula(x, k) / 2);
                k++;
            }
            return (sum);
        }*/

        static double ToFindSum(double x)
        {
            int k = 1;
            double addVar = -1;
            double e = 0.00000001;
            double sum = 1;
            double item = 0.5;

            for (int i = 1; Math.Abs(addVar - sum) > e; i++)
            {
                addVar = sum;

                item *= 4 * x * x / (i*2);
				// ---check--- то же самое, как в предыдущем задании, зачем -1 в степень возводить?
                sum += (Math.Pow((-1), i) * item);

                k = i;
            }

            return (sum);
        }
    }
}
