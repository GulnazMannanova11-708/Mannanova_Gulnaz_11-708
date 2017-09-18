using System;

namespace summa
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 5;
            
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
