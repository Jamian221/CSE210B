class Fraction{
    private int _numerator;
    private int _denominator;
    public Fraction(int numerator, int denominator){
        _numerator = numerator;
        _denominator = denominator;
    }
    public Fraction(){}

    public int GetNumerator()
    {
        return _numerator;
    }
    public void SetNumerator(int numerator){
        _numerator = numerator;
    }
    public int GetDenominator(){
        return _denominator;
    }
    

}