using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the coordinates of two points of the line L alternately(x, y): ");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double y1 = Convert.ToInt32(Console.ReadLine());
            double x2 = Convert.ToInt32(Console.ReadLine());
            double y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the coordinates of the point A (x, y): ");
            double x3 = Convert.ToInt32(Console.ReadLine());
            double y3 = Convert.ToInt32(Console.ReadLine());

            //Введем несколько переменных для упрощения задач
            double a;
            double b;
            double c;
            double p;

            //найдем длину первого отрезка(лежащей на прямой)
            a = y2 - y1;
            b = x2 - x1;
            a = Math.Pow(a, 2) + Math.Pow(b, 2);
            a = Math.Sqrt(a);
            
            //найдем длину второго отрезка
            b = y3 - y2;
            c = x3 - x2;
            b = Math.Pow(b, 2) + Math.Pow(c, 2);
            b = Math.Sqrt(b);
            
            // длина третьего отрезка
            c = y3 - y1;
            p = x3 - x1;
            c = Math.Pow(c, 2) + Math.Pow(p, 2);
            c = Math.Sqrt(c);

            //расстояние от точки до прямой = высота треугольника
            //найдем высоту из метода площадей
            //(по формуле герона и обычной формуле нахождения площади треугольника)
            p = (a + b + c) / 2; //полупериметр
            x1 = (double)Math.Sqrt(p * (p - a) * (p - b) * (p - c)); //формула Герона (площадь треугольника)
            x2 = 2 * x1 / a; //высота треугольника 
            Console.WriteLine(x2);
            Console.ReadKey();
        }
    }
}
