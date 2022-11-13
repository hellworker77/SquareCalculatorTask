using FluentAssertions;
using ShapeSquareCalculator.Implementation.Shapes;

namespace Tests;
public class CircleTests
{
    [Fact]
    public void SquareTestCorrectResult()
    {
        var circle = new Circle(3);
        var exceptedSquare = 9 * Math.PI;

        var square = circle.GetSquare();

        square.Should().Be(exceptedSquare);
    }

    [Fact]
    public void TestNotValidRadius()
    {
        var circle = new Circle(-15);

        var isValid = circle.IsValid();

        isValid.Should().BeFalse();
    }
}