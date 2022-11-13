using ShapeSquareCalculator.Abstractions;

namespace ShapeSquareCalculator.Implementation.Shapes;

public class Circle : IShape
{
    public double Radius { get; private set; }

    public Circle(double radius)
    {
        Radius = radius;
    }
    public double GetSquare()
    {
        var square = Math.PI * Math.Pow(Radius, 2);

        return square;
    }

    public bool IsValid()
    {
        return Radius > 0;
    }

    public override string ToString()
    {
        var result = $"{this.GetType().Name} ";
        return result;
    }
}