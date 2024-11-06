using System;

class Program
{
    class Circle
    {
        private double radius;

        public Circle(double radius){
            this.radius = radius;
        }

        public double GetArea(){
            return Math.PI * radius * radius;
        }

        public double GetDiameter(){
            return 2 * radius;
        }

        public double GetCircumference(){
            return Math.PI * 2 * radius;
        }
        
        public double GetRadius(){
            return radius;
        }
        public void SetRadius(double radius){
            this.radius = radius;
        }

        public void Display(){
            Console.WriteLine($"Area is: {GetArea()}");
            Console.WriteLine($"Radius is: {GetRadius()}");
            Console.WriteLine($"Diameter is: {GetDiameter()}");
            Console.WriteLine($"Circumference is: {GetCircumference()}");
        }


    }
    static void Main(string[] args)
    {
        Console.WriteLine("hajimemashite, Ien desu");
        int x = 10;

        Circle myCircle = new Circle(x);
        Console.WriteLine("First circle");
        myCircle.Display();
        myCircle.SetRadius(x+100);
        Console.WriteLine("Second Circle");
        myCircle.Display();
    }
}