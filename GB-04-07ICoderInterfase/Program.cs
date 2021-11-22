using System;

namespace GB_04_07ICoderInterfase
{
    class Program
    {
        static void Main(string[] args)
        {
            ACoder coder = new ACoder();

            Console.WriteLine(coder.Encode("ыва")); ;
        }
    }
}
