using ShapeSquareCalculator.Abstractions;

namespace ShapeSquareCalculator.Implementation.Shapes;

public class Triangle : IShape
{
    public double SideA { get; private set; }
    public double SideB { get; private set; }
    public double SideC { get; private set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
    public double GetSquare()
    {
        var semiPerimeter = (SideA + SideB + SideC) / 2;

        var squareSquaredValue = semiPerimeter * (semiPerimeter - SideA)
                                          * (semiPerimeter - SideB) *
                                          (semiPerimeter - SideC);

        var square = Math.Sqrt(squareSquaredValue);

        return square;
    }

    public bool IsValid()
    {
        var conditionFirst = SideA + SideB > SideC;
        var conditionSecond = SideB + SideC > SideA;
        var conditionThird = SideC + SideA > SideB;
        var conditionFourth = SideA > 0 && SideB > 0 && SideC > 0;

        return conditionFirst &&
               conditionSecond &&
               conditionThird &&
               conditionFourth;
    }

    public bool IsRectangular()
    {
        var listOfSides = new List<double> { SideA, SideB, SideC };

        var hypotenuse = listOfSides.Max();

        listOfSides = listOfSides.Where(x => !x.Equals(hypotenuse)).ToList();

        var sumOfSidesSquared = listOfSides.Sum(x => Math.Pow(x, 2));

        var condition = Math.Pow(hypotenuse, 2).Equals(sumOfSidesSquared);

        return condition;
    }

    public override string ToString()
    {
        var isRectangular = IsRectangular();

        var rectangularAttachment = isRectangular == true ? " is Rectangular" : string.Empty;

        return $"{this.GetType().Name}{rectangularAttachment}";
    }
}