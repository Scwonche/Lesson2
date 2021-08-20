using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Написать метод, возвращающий минимальное из трёх чисел.
             * 2. Написать метод подсчета количества цифр числа.
             */
            static int mini(int a,int b, int c)
            {
                int min = a < b ? (a < c ? a : c) : (b < c ? b : c);
                return min;
            }
            static int kol(int n)
            {
                int k = 0;
                while (n != 0)
                { 
                    n = n / 10;
                    k++;
                }
                return k;           
            }
            int a, b, c;
            
            a= Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(mini(a, b, c));
            Console.WriteLine(kol(a));
        }
    }
}
