public class Rectangle: Shape
{
    private double _length;
    private double _Width;

    public Rectangle(string color, double length, double width): base(color)
    {
        _length = length;
        _Width = width;
    }
    public double GetLength()
    {
        return 0;
    }
    public void  SetLength(Double Length)
    {

    }
    public double GetWidth()
    {
        return 0;
    }
    public void  SetWidth(Double width)
    {

    }
    public override double GetArea()
    {
        return _length * _Width;

    }


}