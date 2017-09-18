using System;

namespace summa
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            int b = a;

            b = ((a % 10) * 100);
            b += ((a / 10) % 10) * 10;
            b += a / 100;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
