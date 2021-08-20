using System;

namespace Lesson2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0, s = 0;
            int a = int.Parse(Console.ReadLine());
            while (a != 0)
            {
                if (a > 0 && a % 2 != 0) { s = s + a; }
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(s);
        }
    }
}
