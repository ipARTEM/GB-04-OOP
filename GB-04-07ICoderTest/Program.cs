using System;

namespace GB_04_07ICoderTest
{
    // Объявить тип делегата
    delegate int MyDelegate(int a, int b);

    abstract class A
    {
        // Абстрактный метод
        public abstract void Print();

        // Абстрактное свойство
        public abstract int IntProp
        {
            get;
            set;
        }

        // Абстрактный индексатор
        public abstract int this[int index]
        {
            get;
            set;
        }

        // Абстрактное событие
        public abstract event MyDelegate MyEvent;
    }

    // Абстрактный класс A_Abstract - вершина иерархии
    abstract class A_Abstract
    {
        // некоторое внутреннее поле класса
        public int a;
    }

    // Не абстрактный класс B - производный от A_Abstract
    class B : A_Abstract
    {
        public int b;
    }

    // Абстрактный класс C_Abstract - производный от неабстрактного класса B
    abstract class C_Abstract : B
    {
        public int c;
    }

    // Не абстрактный класс D
    class D : C_Abstract
    {
        public int d;
    }

    public interface IMyInterface
    {
        int MyGetInt(); // метод, возвращающий число типа int
        double MyGetPi(); // метод, возвращающий число Pi
        int MySquare(int x); // метод, возвращающий x в квадрате
        double MySqrt(double x); // метод возвращающий корень квадратный из x
    }

    public interface IMyInterface2
    {
        double MySqrt2(double x); // корень квадратный из x
    }


    public class MyClass : IMyInterface
    {
        public int MyGetInt()
        {
            return 25;
        }

        public double MyGetPi()
        {
            return Math.PI;
        }

        public int MySquare(int x)
        {
            return (int)(x * x);
        }

        public double MySqrt(double x)
        {
            return (double)Math.Sqrt(x);
        }
    }

    public class MyClass2 : IMyInterface, IMyInterface2
    {
        // методы из интерфейса MyInterface
        public int MyGetInt()
        {
            return 25;
        }

        public double MyGetPi()
        {
            return Math.PI;
        }

        public int MySquare(int x)
        {
            return (int)(x * x);
        }

        public double MySqrt(double x)
        {
            return (double)Math.Sqrt(x);
        }

        // метод из интерфейса MyInterface2
        public double MySqrt2(double x)
        {
            return (double)Math.Sqrt(x);
        }
    }

    public interface IMyInterface3
    {
        double MyGetPi(); // метод, возвращающий число Pi
    }

    class MyClass3 : IMyInterface3
    {
        // методы из интерфейса MyInterface
        public double MyGetPi()
        {
            return Math.PI;
        }

    }

    struct Time
    {
        private int hours, minutes, seconds;

        
        public Time(int hh, int mm, int ss)
        {
            hours = hh % 24;
            minutes = mm % 60;
            seconds = ss % 60;
        }
        public int Hours()
        {
            return hours;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Объявить экземпляры классов B, D.
            // Экземпляры классов A_Abstract, C_Abstract запрещено объявлять
            B objB = new B();
            D objD = new D();
            // A_Abstract obj = new A_Abstract(); - ошибка

            // 2. Доступ к элементам из экземпляра objB
            objB.a = 23;
            objB.b = 33;
            // obj.d = 40; - ошибка, невозможно доступиться к элементу унаследованного класса

            // 3. Доступ к элементам из экземпляра objD
            objD.a = 77;
            objD.b = 777;
            objD.c = 7777;
            objD.d = 7777;
            Click();

            Time t = new Time(30, 69, 59);
            Console.WriteLine(t.Hours());
            Console.ReadKey();


        }
        public static  void Click()
        {
            MyClass3 mc = new MyClass3(); // создание объекта класса mc
            IMyInterface3 mi; // ссылка на интерфейс
            double d;

            mi = mc; // mi ссылается на объект класса mc
            d = mi.MyGetPi(); // d = 3.14159265358979

            Console.WriteLine(d);
        }
    }
}
