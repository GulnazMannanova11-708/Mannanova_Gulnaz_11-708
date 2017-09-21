using System;

namespace Expr._11_Mannanova
{
    class Program
    {
        static void Main(string[] args)
        {
            int clock = Convert.ToInt32(Console.ReadLine());
            int minutes = Convert.ToInt32(Console.ReadLine()); 
            int degrees = minutes * 6;
            double part = (clock * 30) + minutes * 0.5;//Расчитываем на какую часть сдвинется часовая стрелка от изначального положения
            if (degrees - part > 0)
                Console.WriteLine(degrees - part);
            else
                Console.WriteLine(part - degrees);
            Console.ReadKey();
        }
    }
}
