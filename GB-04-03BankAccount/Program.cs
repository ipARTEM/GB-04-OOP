using System;

namespace GB_04_03BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Example o1 = new Example();
            Example o2 = new Example();
            Example o3 = new Example();
            o1.x = 5;
            o2.x = 7;
            o3.x = 9;

            o3 = o2;
            o2.x = o1.x;
            o2.x = 12;

            Console.WriteLine(o1.x);
            Console.WriteLine(o2.x);
            Console.WriteLine(o3.x);


            Car mycar = new Car();

            Car car = new Car("Player", 50, 75);

            Car car1 = new Car("Player", 50, 75);

            if (car == car1)
            {
                Console.WriteLine("true");

                Console.WriteLine(car.GetHashCode());
                Console.WriteLine(car1.GetHashCode());
            }
            else
            {
                Console.WriteLine("false");

                Console.WriteLine(car.GetHashCode());
                Console.WriteLine(car1.GetHashCode());
            }

            Console.ReadKey();

            if (car.X == car1.X && car.Y == car1.Y)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            int num = 2;

            Multiply(num);

            Console.WriteLine(num);


        }
        private static void Multiply(int num)
        {
            num *= 2;
        }
    }

    class Example
    {
        public int x;
    }

    class Car
    {

        int _x = 50;
        int _y = 100;

        public int X { get; set; } = 10;
        public int Y { get; set; } = 10;

        string _name = "John";

        public Car()
        {

        }

        public Car(string name, int x, int y)
        {
            _x = x;
            _y = y;
            _name = name;

        }



    }





}
