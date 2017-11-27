using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2._3._4
{
    class Program
    {
        static void Main()
        {
            int segment = int.Parse(Console.ReadLine())/2*2;
            double area = 0;
            double a = 0;
            double b = 1.5;
            double lengthSegment = (b - a) / segment;
            int k = 1;

            for (double i = a + lengthSegment; i < b; i += lengthSegment)
            {
                if (k % 2 == 0) area += 2 * Math.Sin(2 * i) / Math.Cos(i) / Math.Cos(i);
                else area += 4 * Math.Sin(2 * i) / Math.Cos(i) / Math.Cos(i);
                k++;
            }
            area += Math.Sin(2 * a) / Math.Cos(a) / Math.Cos(a) 
                + Math.Sin(2 * b) / Math.Cos(b) / Math.Cos(b);
            area *= lengthSegment/3;

            Console.WriteLine(area);
            Console.ReadKey();
        }
    }
}
