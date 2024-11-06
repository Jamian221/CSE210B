using System;

class Program
{
    class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("hajimemashite, Ien desu");
        int x = 10;

        Circle myCircle = new Circle(x);

        Console.WriteLine(myCircle.GetArea());
    }
}