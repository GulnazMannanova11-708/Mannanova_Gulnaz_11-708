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
            //Маннанова Гульназ, задача 3 пункт 4
            // на нахождение определ.интеграла методом Монте-Карло
            int segment = int.Parse(Console.ReadLine());

            //вводим рандом:
            Random random = new Random();
            double area = 0;
            double a = 0;
            double b = 1.5;

            //счетчик, который считает: сколько точек вошло под график
            int k = 0;

            for (int i = 0; i < segment; i++)
            {
                double x = random.NextDouble() * (b - a) + a;
                //40 - высота >= max значения этой функции
                double y = random.NextDouble() * 40;
                //сравниваем значение у и значение функ. в точке х
                if (y <= Math.Sin(2 * x) / Math.Cos(x) / Math.Cos(x)) k++;

                //площадь прямоугольника * на число точек, попавших под график функции
                //и делим на общее число точек
                area = 40 * b * k / segment;
            }
          
            Console.WriteLine(area);
            Console.ReadKey();
        }
    }
}
