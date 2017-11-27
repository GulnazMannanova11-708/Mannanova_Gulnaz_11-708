using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2._3._5
{
    class Program
    {
        static void Main()
        {
            int segment = int.Parse(Console.ReadLine()) / 2 * 2;

            Random random = new Random();
            double area = 0;
            double a = 0;
            double b = 1.5;
            double lengthSegment = (b - a) / segment;
            int k = 0;

            for (int i = 0; i < segment; i++)
            {
                double x = random.NextDouble() * (b - a) + a;
                double y = random.NextDouble() * 40;
                if (y <= Math.Sin(2 * x) / Math.Cos(x) / Math.Cos(x)) k++;
                area = 40 * b * k / segment;
            }
          
            Console.WriteLine(area);
            Console.ReadKey();
        }
    }
}
