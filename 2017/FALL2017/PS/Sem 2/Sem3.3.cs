using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem2._3._3
{
    class Program
    {
        static void Main()
        {
            int segment = int.Parse(Console.ReadLine());
            double area = 0;
            double a = 0;
            double b = 1.5;
            double lengthSegment = (b - a) / segment;


            for (double i = a + lengthSegment; i < b; i += lengthSegment)
                area += Math.Sin(2 * i) / Math.Cos(i) / Math.Cos(i);
            area += (Math.Sin(2 * a) / Math.Cos(a) / Math.Cos(a) + 
                Math.Sin(2 * b) / Math.Cos(b) / Math.Cos(b)) / 2 ;
            area *= lengthSegment;

            Console.WriteLine(area);
            Console.ReadKey();
        }
    }
}
