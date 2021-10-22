using System;

namespace GB_04_04Building01
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new ();
            building.Add(3,4,5);

            Building building2 = new();
            building2.Add(4, 8, 7, 5);

            building.Print();
            building2.Print();
            building.Print();

        }
    }
}
