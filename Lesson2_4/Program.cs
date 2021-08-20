using System;

namespace Lesson2_4
{
    class Program
    {
        static void Main(string[] args)
        /*Реализовать метод проверки логина и пароля. 
         * На вход метода подается логин и пароль. 
         * На выходе истина, если прошел авторизацию, и ложь, если не прошел 
         * (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: 
         * пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
         * С помощью цикла do while ограничить ввод пароля тремя попытками.
         */
        {
            static bool IsTrueLog(string s)
            {
                if (s != "root") return false;
                else return true;
            }
            static bool IsTruePas(string s)
            {
                if (s != "GeekBrains") return false;
                else return true;
            }
            
            string log,pas;
            int k = 3;
            do
            {
                Console.Write("Login:");
                log = Console.ReadLine();
                Console.Write("Password:");
                pas = Console.ReadLine();
                k--;
            }
            while ((k > 0) & IsTrueLog(log) & IsTruePas(pas));
                

        }
    }
}
