using System;

public class Rectangle 
:Shapes
{
    private int _length = 0;
    private int _width = 0;

    public int Length()
    {
        return _length;

    }
    public void SetLength(int length)
    {
        _length = length;

    }
    public int Width()
    {
        return _width;

    }
    public void SetWidth(int width)
    {
        _width = width;

    }
    public Rectangle (string color,int length,int width)
    : base(color)
    {
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {  
        double area ;
        area = _length * _width; 
        return area ;
    }
}