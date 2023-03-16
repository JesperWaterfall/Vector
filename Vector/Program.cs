using System;

namespace Vector
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Vector vector = new Vector(3, 4);
            Console.WriteLine(vector.ToString());
            vector.X = 0;
            vector.Y = -1;
            Console.WriteLine(vector.ToString());
            vector = new Vector(9, 40);
            Console.WriteLine(vector.ToString());
            Console.WriteLine(new Vector(0, 0).ToString());
        }
    }
}