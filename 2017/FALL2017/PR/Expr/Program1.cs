using System;

namespace Expr._1_Mannanova
{
    class Program
    {
        static void Main(string[] args)
        {
             int H = Convert.ToInt32(Console.ReadLine());
            //т.к. один час = 30 градусов (360гр./12часов), то
            if (H <=6 )
            {
                H = H * 30;
            }
            else  if ((H>6) && (H<=12))//т.к. программа с 8 ч. считает угол м/у стрелками = 120гр.
            {
                H = 360 - (H * 30); 
            }
            else if ((H>12) && (H<=18))
            {
                H = H - 12;
                H = H * 30;
            }
            else
            {
                H = H - 12;
                H = 360 - (H * 30);
            }
            Console.WriteLine("Angle between arrows = "+ H);
            Console.ReadKey();
        }
    }
}
