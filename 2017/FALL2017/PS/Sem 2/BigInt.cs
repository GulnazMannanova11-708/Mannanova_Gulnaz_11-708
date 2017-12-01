using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigInt_altered
{
    class Program
    {
        static void Main()
        {
            //Mannanova Gulnaz 11-708 BigInt

            int number = int.Parse(Console.ReadLine());
            int[] sum = new int[100];

            for (int i = 1; i<= number; i++)
            {
                var factorial = ToFindSquareFactorial(i);
                sum = ToFindSum(sum, factorial);
            }
           
            Array.Reverse(sum);
            sum = ArrayFragmentation(sum);
            foreach (var e in sum)
                Console.Write(e);

            Console.ReadKey();
        }

        //Метод нахождения квадрата факториала
        //....
        //....
        public static int[] ToFindSquareFactorial(int n)
        {
            int[] result = new int[100];
            result[0] = 1;

            for (int i = 1; i <= n; i++)
            {
                var array = ToConvertNumToArray(i);
                result = ToFindProduct(array, result);
            }

            return ToFindProduct(result, result);
        }


        //Метод нахождения суммы чисел
        //....
        //....
        public static int[] ToFindSum(int[] a, int[] b)
        {
            //Меняет ссылки на массив, если первое число окажется меньше второго
            if (a.Length < b.Length)
            {
                var c = a;
                a = b;
                b = c;
            }
            int maxItem = a.Length;
            int minItem = b.Length;

            var result = new int[maxItem + 1]; //Массив, куда будет введен результат
            int remainder = 0; //остаток

            for (int i = 0; i < minItem; i++)
            {
                result[i] = a[i] + b[i] + remainder;
                if (result[i] > 9)
                {
                    remainder = result[i] / 10;
                    result[i] %= 10;
                }
                else remainder = 0;
            }


            for (int i = minItem; i < maxItem; i++)
            {
                result[i] = a[i] + remainder;
                //здрасьте, меня зовут Гульназ,
                //и я не люблю делать отдельно методы
                if (result[i] > 9)
                {
                    remainder = result[i] / 10;
                    result[i] %= 10;
                }
                else remainder = 0;
            }


            if (remainder != 0) result[maxItem] = remainder;
            return result;
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

        //Метод нахождения произведения чисел
        //....
        //....
        public static int[] ToFindProduct(int[] a, int[] b)
        {
            //Меняет ссылки на массив, если первое число окажется меньше второго
            if (a.Length < b.Length)
            {
                var c = a;
                a = b;
                b = c;
            }
            int maxItem = a.Length;
            int minItem = b.Length;

            //создаем новый массив, куда будем помещать результат;
            var result = new int[minItem + maxItem];
            int remainder = 0;

            //умножаем поэлементно
            for (int i = 0; i < minItem; i++)
            {
                var resultAdd = new int[maxItem + minItem];
                for (int j = 0; j < maxItem; j++)
                {
                    resultAdd[i + j] += a[j] * b[i];
                    if (resultAdd[i + j] > 9)
                    {
                        remainder = resultAdd[i + j] / 10;
                        resultAdd[i + j] %= 10;
                    }
                    else remainder = 0;
                    resultAdd[i + j + 1] = remainder;
                }
                result = ToFindSum(result, resultAdd);
            }
            return result;
        }

        //Метод, который убирает 0 
        //....
        //....
        //....
        public static int[] ArrayFragmentation(int[] array)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                    counter++;
                else break;
            }
            var newArray = new int[array.Length - counter];
            for (int i = counter; i < array.Length; i++)
            {
                newArray[i - counter] = array[i];
            }
            return newArray;
        }

    }
}
