class Rectangle :Shape{
    private double _length;
    private double _width;

    public override double GetArea(){
        double area = _length * _width;
        return area;
    }

}