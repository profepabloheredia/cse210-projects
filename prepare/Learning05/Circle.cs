using System;
public class Circle: Shape
{

    private double _radius;

    public Circle(string color, double radius):base (color)
    {
        _radius=radius;
    }
    public double GetRadius()
    {
        return 0;
    }
    public void  SetRadius(Double radius)
    {

    }
    public override double GetArea()
    {
        return Math.PI *_radius * _radius;
    }

}