using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 20.55);
        Rectangle rectangle = new Rectangle("purple", 17, 20.78);
        Circle circle = new Circle("yellow", 50);
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        foreach (Shape shape in shapes){
            Console.WriteLine($"Shape: {shape.GetShape()}, Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }

   
    }
}