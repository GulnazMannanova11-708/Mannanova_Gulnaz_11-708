using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem6
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите номер простого числа:  ");
            int primeNumb = int.Parse(Console.ReadLine());
            int counter = 0;
            int i = 0;
            while(primeNumb != counter)
            {
                i++;
                bool execution = true;
                for (int j = 2; j <= i / 2; j++)//проверяем, является ли число простым
                    if (i % j == 0)
                    {
                        execution = false;
                        break;
                    }
                if (execution) counter++;//считаем, какое по счету простое число
            }
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
