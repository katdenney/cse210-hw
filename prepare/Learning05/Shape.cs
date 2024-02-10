using System;
public class Shapes
{
    private string _color;

    public string GetColor()
    {
        return _color;

    }
    public void SetColor(string color)
    {
        _color = color;

    }
    public Shapes(string color)
    {
        _color = color;
    }
    public virtual int GetArea()
    {
        return -1;

    }

}