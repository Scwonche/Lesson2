using System;

namespace Lesson2_6
{
    class Program
        /* Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
         * «Хорошим» называется число, которое делится на сумму своих цифр.
         * Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
         * */
    {
        static void Main(string[] args)
        {
            static int sumc(int n)
            {
                int s=0;
                while (n!=0)
                    {
                    s = s+ n % 10;
                    n =n/ 10;
                    }
                return s;
                    
            }
            int k = 0;
            DateTime start = DateTime.Now;
            for (int i = 1; i <= Math.Pow(10,9); i++)
            {
                if (i % sumc(i) == 0)
                    k++;
            }
            Console.WriteLine(DateTime.Now - start);

            Console.WriteLine(k);
        }
    }
}
