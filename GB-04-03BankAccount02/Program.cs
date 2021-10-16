using System;

namespace GB_04_03BankAccount02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");

            string str = Console.ReadLine();

            str= Rev(str);

            Console.WriteLine(str);


        }

        static string Rev(string str)
        {

            char[] reverse = str.ToCharArray();

            Array.Reverse(reverse);

            return new string(reverse);

        }
    }
}
