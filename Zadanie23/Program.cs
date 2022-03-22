using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework23
{
    class Program
    {
        public static long FactorialAsync(int N)
        {
            long factotial = 1;
            if (N != 0)
            {
                for (int i = 2; i <= N; i++)
                {
                    factotial *= i;
                }
            }
            return factotial;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int N = Int32.Parse(Console.ReadLine());
            if (N >= 0)
            {
                Console.WriteLine($"Факториал числа {N}: {FactorialAsync(N)}");
            }
            else
            {
                Console.WriteLine("Было введено отрицательное число!");
            }
            Console.Write("Нажмите любую клавишу для выхода из программы...");
            Console.ReadKey();
        }
    }
}