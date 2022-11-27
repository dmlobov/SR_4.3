using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размеры прямоугольника AxB");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размеры квадрата СхС");
            int C = Convert.ToInt32(Console.ReadLine());
            double F1 = A * B;
            double F2 = C * C;
            int n = 0;
            while (F1 > 0)
            {
                F1 -= F2;
                n++;
            }
            Console.WriteLine("Количество квадратов в прямоугольнике {0}", n);
            Console.ReadKey();
        }
    }
}
