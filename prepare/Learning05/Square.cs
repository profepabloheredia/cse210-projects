 class Square : Shape
{
    private double _side;

    public Square(string color, double side): base(color)
    {
        _side= side;
    }
    public double GetSide()
    {
        return 0;
    }
    public void  SetSide(Double side)
    {

    }
    public override double GetArea()
    {
        return _side * _side;
        
    }








}