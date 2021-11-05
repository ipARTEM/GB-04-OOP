using System;

namespace GB_05_00
{

    class Calculate
    {
        public static int Square(int number)
        {
            Console.WriteLine("Integer Square calculated");
            return number * number;
        }


        public static double Square(double number)
        {
            Console.WriteLine("Double Square calculated");
            return number * number;
        }

        //public static int Square(double number)
        //{
        //    return (int)(number * number);
        //}
    }

    class Rectangle
    {
        private int _height;
        private int _width;

        public Rectangle(int height, int width)
        {
            if (height <= 0) throw new ArgumentException("height");
            if (width <= 0) throw new ArgumentException("width");

            _height = height;
            _width = width;

            Console.WriteLine("Rectangle Constructor Called");
        }

        public Rectangle(int size)
        {
            if (size <= 0) throw new ArgumentException("height");
            _height = _width = size;
            Console.WriteLine("Square Constructor Called");
        }



        public int Height
        {
            get { return _height; }
        }

        public int Width
        {
            get { return _width; }
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            double squareMe = 5;
            int squareMeToo = 5;
            Console.WriteLine(Calculate.Square(squareMe));
            Console.WriteLine(Calculate.Square(squareMeToo));

            float squareMefloat = 5;
            Console.WriteLine(Calculate.Square(squareMefloat));

            Rectangle rect = new Rectangle(4, 6);
            Console.WriteLine("Height: {0}", rect.Height);
            Console.WriteLine("Width: {0}", rect.Width);

            Rectangle square = new Rectangle(5);
            Console.WriteLine("Height: {0}", square.Height);
            Console.WriteLine("Width: {0}", square.Width);



        }
    }
}
