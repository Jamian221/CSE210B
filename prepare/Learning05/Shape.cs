class Shape{
    private string _color;
    protected string _shape;
    public Shape(string color){
        _color = color;
    }
    public virtual double GetArea(){
        double area = 0;
        return area;
    }
    public string GetColor(){
        return _color;
    }
    public void SetColor(string color){
        _color = color;
    }
    public string GetShape(){
        return _shape;
    }
}