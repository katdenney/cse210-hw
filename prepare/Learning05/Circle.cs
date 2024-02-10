using System;

public class Circle 
:Shapes
{
    private double _radius = 0;

    public double Radius()
    {
        return _radius;

    }
    public void SetRadius(double radius)
    {
        _radius = radius;

    }
    public Circle (string color,double radius)
    : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {  
        double area ;
        area = Math.PI * _radius * _radius; 
        return area ;
    }
}