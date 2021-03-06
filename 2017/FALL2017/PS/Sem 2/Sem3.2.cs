﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem2._3._2
{
    class Program
    {
        static void Main()
        {
            //Маннанова Гульназ, задача 3 пункт 2
            // на нахождение определ.интеграла методом правых прямоугольников
            int segment = int.Parse(Console.ReadLine());
            double area = 0;
            double a = 0;
            double b = 1.5;
            double lengthSegment = (b - a) / segment;

            //все то же самое, только все знаения + lengthSegment
            for (double i = a + lengthSegment; i <= b; i += lengthSegment)
                area += Math.Sin(2 * i) / Math.Cos(i) / Math.Cos(i);
            area *= lengthSegment;

            Console.WriteLine(area);
            Console.ReadKey();
        }
    }
}
