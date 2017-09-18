using System;

namespace Expr._5_Mannanova
{
    class Program
    {
        static void Main()
        {
           int a = 1899;
           int b = 1912;
            a = b - a;//промежуток между годами
            b = (int)a / 4 - (int)a / 100 + (int)a / 400;//число високосных дней
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
