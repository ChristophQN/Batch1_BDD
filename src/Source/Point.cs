using System;

namespace MarsRovers
{
    class Point
    {
        public Point(int v1, int v2)
        {
            X = v1;
            Y = v2;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Point point &&
                   X == point.X &&
                   Y == point.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
    }
}