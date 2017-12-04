using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem5
{
    class Program
    {
        static void Main()
        {
            int perfNumb = 0;
            Console.WriteLine("Совершенные числа: ");
            for (int num = 1; num <= 1000000; num++)
            {
                int sum = 0;
                for (int divider = 1; divider <= num / 2; divider++)//перебираем все возможные делители числа
                {
                    if (num % divider == 0) sum += divider;//находим сумму всех делителей данного числа
                }

		// ---check--- по условию не с числом n, а с 2*n
                if (sum == num)//если сумма делителей совпадает с числом, то выводим на экран совершенное число
                {
                    Console.WriteLine(num);
                    perfNumb++;
                }
            }
            Console.WriteLine(perfNumb);
        }
    }
}
