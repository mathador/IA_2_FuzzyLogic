using System;

namespace FuzzyLogicPCL;

public class Point2D : IComparable
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    public int CompareTo(object obj)
    {
        return (int)(X - ((Point2D)obj).X);
    }

    public override string ToString() => $"({X};{Y})";
}
