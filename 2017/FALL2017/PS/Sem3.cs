using System;

namespace Sem._3_Mannanova
{
    class Program
    {
        static void Main(string[] args)
        {
            //Условие: перевести число n (n<10^18) в шестнадцатеричную систему счисления (0123456789ABCDEF)
            int n = int.Parse(Console.ReadLine());
            String result = "";

            while (n > 0)
            {
                switch (n % 16)
                {
                    case 10:
                        result += "A";
                        break;
                    case 11:
                        result += "B";
                        break;
                    case 12:
                        result += "C";
                        break;
                    case 13:
                        result += "D";
                        break;
                    case 14:
                        result += "E";
                        break;
                    case 15:
                        result += "F";
                        break;
                    default:
                        result += n % 16;
                        break;
                }

                n /= 16;
            }

            Char[] a = result.ToCharArray();
            string newResult = "";
            
            for (int i = a.Length - 1; i >= 0; i--)
            {
                newResult += a[i];
            }



            Console.WriteLine(newResult);
            Console.ReadKey();
        }
    }
}
