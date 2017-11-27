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
            //Маннанова Гульназ, задача 3 пункт 4
            // на нахождение определ.интеграла методом Симпсона

            //т.к. нам обязательно нужно четное число:
            int segment = int.Parse(Console.ReadLine())/2*2;

            double area = 0;
            double a = 0;
            double b = 1.5;
            double lengthSegment = (b - a) / segment;

            //вводим счетчик, который поможет в цикле
            int k = 1;

            for (double i = a + lengthSegment; i < b; i += lengthSegment)
            {
                //i в нечет. позициях умножаются на 2, а на чет. на 4;
                if (k % 2 == 0) area += 2 * Math.Sin(2 * i) / Math.Cos(i) / Math.Cos(i);
                else area += 4 * Math.Sin(2 * i) / Math.Cos(i) / Math.Cos(i);
                k++;
            }
            //прибавляем значения в т. a и b
            area += Math.Sin(2 * a) / Math.Cos(a) / Math.Cos(a) 
                + Math.Sin(2 * b) / Math.Cos(b) / Math.Cos(b);
            //значение площади умножаем на данное число:
            area *= lengthSegment/3;

            Console.WriteLine(area);
            Console.ReadKey();
        }
    }
}
