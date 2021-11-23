using System;

namespace GB_04_07ICoderInterfase
{
    class Program
    {
        static void Main(string[] args)
        {
            ACoder aCoder = new ();
            Console.WriteLine(aCoder.Encode("АБвя"));
            aCoder.Clear();
            Console.WriteLine(aCoder.Decode("БВга"));

            BCoder bCoder=new ();
            Console.WriteLine(bCoder.Encode("АБвя"));
            bCoder.Clear();
            Console.WriteLine(bCoder.Decode("ЯЮэа"));
        }
    }
}
