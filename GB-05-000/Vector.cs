using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_05_000
{
    public class Vector
    {
        private int _x, _y;

        public Vector(int x, int y)
        { 
            _x = x; 
            _y = y; 
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static Vector operator *(Vector v1, int scale)
        {
            return new Vector(v1.X * scale, v1.Y * scale);
        }

        public static Vector operator *(int scale, Vector v1)
        {
            return new Vector(v1.X * scale, v1.Y * scale);
        }

        public static Vector operator ++(Vector v)
        {
            v.X++;
            v.Y++;
            return v;
        }

        public static Vector operator --(Vector v)
        {
            v.X--;
            v.Y--;
            return v;
        }

        public static Vector operator -(Vector v)
        {
            return new Vector(-v.X, -v.Y);
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            return (v1.X == v2.X && v1.Y == v2.Y);
        }

        public static bool operator !=(Vector v1, Vector v2)
        {
            return (v1.X != v2.X || v1.Y != v2.Y);
        }
        public double Length
        {
            get { return Math.Sqrt(_x * _x + _y * _y); }
        }

        public static bool operator >(Vector v1, Vector v2)
        {
            return (v1.Length > v2.Length);
        }

        public static bool operator <(Vector v1, Vector v2)
        {
            return (v1.Length < v2.Length);
        }

        public static bool operator >=(Vector v1, Vector v2)
        {
            return (v1.Length >= v2.Length);
        }

        public static bool operator <=(Vector v1, Vector v2)
        {
            return (v1.Length <= v2.Length);
        }

        public static implicit operator double(Vector v)
        {
            return v.Length;
        }

        public static explicit operator float(Vector v)
        {
            return (float)v.Length;
        }

        
        


    }
}
