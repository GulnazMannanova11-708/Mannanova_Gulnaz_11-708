using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigInt
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] sum = new int [number*number];

            for (int i = 0; i <= number; i++)
                sum = ToFindSum(sum, ToConvertNumToArray(i));
            sum.Reverse();
            foreach (var e in sum)
                Console.Write(e);
            Console.ReadKey();
           /* for (int n = 1; n <= number; n++)
            {
                int[] composition = new int[n * n];
                composition[0] = 1;

                for (int i = 1; i <= n; i++)
                {
                    composition = ToFindProduct(composition, ToConvertNumToArray(i));
                }

                composition = ToFindProduct(composition, composition);
                sum = ToFindSum(sum, composition);
            }

            sum.Reverse();
            foreach (var e in sum)
                Console.Write(e);
            Console.ReadKey();
            */
        }

        //Переводим число в массив без reversed, т.к. умножать и складывать легче:
        //....
        //....
        public static int[] ToConvertNumToArray(int a)
        {
            List<int> number = new List<int>();

            while (a > 0)
            {
                number.Add(a % 10);
                a /= 10;
            }

            return (number.ToArray());
        }

        //Метод нахождения суммы чисел
        //....
        //....
        public static int[] ToFindSum(int[] a, int[] b)
        {
            //На этом шаге проверяем max длину числа
            //Вводим флажок, чтобы (*)
            bool k = true;
            int maxItem = a.Length;
            int minItem = b.Length;

            if (maxItem < minItem)
            {
                int item = maxItem;
                maxItem = minItem;
                minItem = item;
                k = false;
            }

            //создаем новый массив, куда будем помещать результат;
            //длина массива на 1 элемент больше максимального, т.к. последние 2 эл в сумме мб > 0;
            var result = new int[maxItem + 1];
            int remainder = 0;

            for (int i = 0; i < minItem; i++)
            {
                result[i] = a[i] + b[i] + remainder;
                if (result[i] > 9)
                {
                    remainder = result[i] / 10;
                    result[i] %= 10;
                }
            }

            for (int i = minItem; i < maxItem; i++)
            {
                if (k) // (*)
                       //я не знаю как сделать, чтобы каждый раз при входе в цикл 
                       //это условие не проверялось :с 
                    result[i] = a[i] + remainder;
                else result[i] = b[i] + remainder;
            }

            if (remainder != 0) result[maxItem] = remainder;
            return result;
        }

        //Метод нахождения произведения чисел
        //....
        //....
        public static int[] ToFindProduct(int[] a, int[] b)
        { 
            //На этом шаге проверяем max длину числа
            //Вводим флажок, чтобы (*)
            //и да, я знаю, что это можно выделить в отдельный метод, но зачем засорять программу?
            bool k = true;
            int maxItem = a.Length;
            int minItem = b.Length;

            if (maxItem < minItem)
            {
                int item = maxItem;
                maxItem = minItem;
                minItem = item;
                k = false;
            }

            //создаем новый массив, куда будем помещать результат;
            var result = new int[minItem + maxItem];
            int remainder = 0;

            //простите за такое кол.-во строк, в общем, эта штучка производит умножение:
            if (k)
            {
                for (int i = 0; i < minItem; i++)
                {
                    var resultAdd = result;
                    for (int j = 0; j < maxItem; j++)
                    {
                        resultAdd[i + j] += a[j] * b[i];
                        if (resultAdd[i + j] > 9)
                        {
                            remainder = resultAdd[i + j] / 10;
                            resultAdd[i + j] %= 10;
                        }
                        resultAdd[i + j] += resultAdd[i + j];
                        resultAdd[i + j + 1] = remainder;
                    }
                    result = ToFindSum(result, resultAdd);
                }
            }

            else
            {
                for (int i = 0; i < minItem; i++)
                {
                    var resultAdd = result;
                    for (int j = 0; j < maxItem; j++)
                    {
                        resultAdd[i + j] += a[i] * b[j];
                        if (resultAdd[i + j] > 9)
                        {
                            remainder = resultAdd[i + j] / 10;
                            resultAdd[i + j] %= 10;
                        }
                        resultAdd[i + j] += resultAdd[i + j];
                        resultAdd[i + j + 1] = remainder;
                    }
                    result = ToFindSum(result, resultAdd);
                }
            }
            return result;
        }
    }
}
