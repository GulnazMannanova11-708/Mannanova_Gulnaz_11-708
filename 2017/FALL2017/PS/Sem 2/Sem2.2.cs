using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem2 
{
    class Program
    {
        static void Main()
            //здрасьте, я Маннанова Гульназ, 
            //и я не люблю писать комментраии
            // задача 2 на нахождения числа Pi
			//---check--- здравствуйте, а я - Салимов Рустем. Надо полюбить писать комментарии!
        {
            double a = 1;
            double b = 1 / Math.Sqrt(2);
            double t = 0.25;
            int p = 1;
            double item = -1;
            double sum = 0;
			//---check--- точность надо было дать вводить пользователю вашей программы
            double e = 0.00000001;

            while (sum - item > e)
            {
                double aAdd = a;
                double bAdd = b;
                
                //все по формуле (я даже не знаю, что коммитить)
                item = sum;
                sum = Math.Pow(a + b, 2) / 4 / t;

                a = (aAdd + bAdd) / 2;
                b = Math.Sqrt(aAdd * bAdd);
                t -= p * Math.Pow((aAdd - a), 2);
                p *= 2;
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
