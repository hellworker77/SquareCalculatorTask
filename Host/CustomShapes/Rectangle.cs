using ShapeSquareCalculator.Abstractions;

namespace Host.CustomShapes;

public class Rectangle : IShape
{
    public double SideA { get; set; }
    public double SideB { get; set; }

    public Rectangle(double sideA, double sideB)
    {
        SideA = sideA;
        SideB = sideB;
    }
    public double GetSquare()
    {
        return SideA * SideB;
    }

    public bool IsValid()
    {
        return SideA > 0 && SideB > 0;
    }

    public override string ToString()
    {
        return $"Custom {GetType().Name}";
    }
}