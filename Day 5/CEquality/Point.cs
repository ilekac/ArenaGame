using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CEquality
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"Point. X = {X}, Y = {Y}";
        }

        public override bool Equals(object? obj)
        {
            Point p = obj as Point;
            if (p is null) return false;
            return this.X == p.X && this.Y == p.Y;
        }

        public static bool operator ==(Point a, Point b)
        {
            if (a is null || b is null) return false;
            return a.Equals(b);
        }

        public static bool operator !=(Point a, Point b)
        {
            if (a is null || b is null) return true;
            return !a.Equals(b);
        }
    }
}
