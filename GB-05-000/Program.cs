using System;

namespace GB_05_000
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(4, 11);
            Vector v2 = new Vector(0, 8);

            Vector v3 = v1 + v2;

            Vector v4 = v2 - v3;

            Vector v5 = v1 * 3;

            Console.WriteLine($"({v3.X}, {v3.Y})");
            Console.WriteLine($"({v4.X}, {v4.Y})");
            Console.WriteLine($"({v4.X}, {v4.Y})");
            Console.WriteLine($"({v5.X}, {v5.Y})");

            Vector v6 = new Vector(8, 88);

            v6++;
            Console.WriteLine("({0},{1})", v6.X, v6.Y);    

            v6--; 
            Console.WriteLine("({0},{1})", v6.X, v6.Y);

            Vector v7 = new Vector(7, 77);

            Vector v8 = -v7;
            Console.WriteLine("({0},{1})", v8.X, v8.Y);

            Vector v11 = new Vector(3, 4);
            Vector v12 = new Vector(3, 4);
            Vector v13 = v12;

            Console.WriteLine(v12 == v11);                //  "False"         //    После перегрузки  операторов      "True" 
            Console.WriteLine(v13 == v12);                //  "True"          //    После перегрузки  операторов      "True"

            Console.WriteLine(v12.Equals(v11));           //  "False"
            Console.WriteLine(v13.Equals(v12));           //  "True"

        }
    }
}
