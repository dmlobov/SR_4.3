﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += 2 * i - 1;
                Console.WriteLine("Квадрат числа {0} равен {1}", i, s);
            }
            Console.ReadKey();
        }
    }
}
