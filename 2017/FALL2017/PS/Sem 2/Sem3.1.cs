using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem2._3._1
{
    class Program
    {
        static void Main()
            //Маннанова Гульназ, задача 3 пункт 1
            // на нахождение определ.интеграла методом левых прямоугольников
        {
            int segment = int.Parse(Console.ReadLine());
            double area = 0;
            double a = 0;
            double b = 1.5;
            //длина отрезка 
            double lengthSegment = (b - a) / segment;

            //по формуле высчитываем сумму всех значений в точках от а до b - lengthSegment  
            for (double i = a; i < b; i += lengthSegment)
                area += Math.Sin(2 * i) / Math.Cos(i) / Math.Cos(i);
            //все это значение умножаем на длину отрезка
            area *= lengthSegment;

            Console.WriteLine(area);
            Console.ReadKey();
        }
    }
}
