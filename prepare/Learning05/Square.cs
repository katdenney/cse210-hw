using System;

public class Square 
:Shapes
{
    private int _side = 0;

    public int GetSide()
    {
        return _side;

    }
    public void SetSide(int side)
    {
        _side = side;

    }
    public Square (string color,int side)
    : base(color)
    {
        _side = side;
    }
    public override double GetArea()
    {  
        int area ;
        area = _side * _side; 
        return area ;
    }
}