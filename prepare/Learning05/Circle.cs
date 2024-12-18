using System.Formats.Asn1;

class Circle :Shape{
    private double _radius;
    public Circle(string color, double radius) :base(color){
        _radius = radius;
        _shape = "Circle";
    }
    public override double GetArea()
    {
        double area = _radius * _radius * Math.PI;
        return area;
    }
}