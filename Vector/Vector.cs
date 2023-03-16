using System;
using System.Collections.Generic;
using System.Text;

namespace Vector
{
    public class Vector
    {
        private double x;
        private double y;

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
            Length = Math.Sqrt(x * x + y * y);
        }

        public double X
        {
            get { return x; }
            set { x = value; Length = Math.Sqrt(x * x + y * y); }
        }

        public double Y
        {
            get { return y; }
            set { y = value; Length = Math.Sqrt(x * x + y * y); }
        }

        public double Length { get; private set; }

        public override string ToString()
        {
            return string.Format("({0}, {1}) with length: {2}", X, Y, Length);
        }
    }
}