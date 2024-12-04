class Square :Shape{
    private double _side;
    public override double GetArea(){
        double area = _side * _side;
        return area;
    }
}