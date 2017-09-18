using System;

namespace Expr._8_Mannanova
{
    class Program
    {
        static void Main(string[] args)
        {
            //прямая задается коэф. а и b (ax + b = y);
            Console.WriteLine("Введите поочередно коэффициенты прямой (a,b): ");
            double a1 = Convert.ToInt32(Console.ReadLine());
            double b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты точки А (х,у): ");
            double x = Convert.ToInt32(Console.ReadLine());
            double y = Convert.ToInt32(Console.ReadLine());
            //коффициенты второго уравнения
            double a2;
            double b2;

            if (a1 == 0)
            {
                Console.WriteLine("На координатной прямой нельзя построить прямую, перпендикулярную данной");
            }
            else
            {
                a2 = (-1) / a1;//тк прямые перпендикулярны, то для них справедливо tg a1 * tg a2 = -1
                b2 = y - a2 * x;
                //a1 * x + b1 = a2 * x + b2 тк прямые пересекаются в определенной точке
                x = (b1 - b2) / (a2 - a1);
                y = a1 * x + b1;
                Console.WriteLine("Координаты точки пересечения ("+x+";"+y+")");
            }
            Console.ReadKey();

        }
    }
}
