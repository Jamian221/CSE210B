using System.Formats.Asn1;

class Circle :Shape{
    private double _radius;
    public override double GetArea()
    {
        double area = _radius * _radius * Math.PI;
        return area;
    }
}