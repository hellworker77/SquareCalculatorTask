using FluentAssertions;
using ShapeSquareCalculator.Implementation.Shapes;

namespace Tests;
public class TriangleTests
{
    [Fact]
    public void SquareTestCorrectResult()
    {
        var triangle = new Triangle(3, 4, 5);
        var exceptedSquare = 6;

        var square = triangle.GetSquare();

        square.Should().Be(exceptedSquare);
    }

    [Fact]
    public void TestNotValidSides()
    {
        var triangle = new Triangle(3, -14, 5);

        var isValid = triangle.IsValid();

        isValid.Should().BeFalse();
    }

    [Fact]
    public void TestIsRectangular()
    {
        var triangle = new Triangle(3, 4, 5);

        var isRectangular = triangle.IsRectangular();

        isRectangular.Should().BeTrue();
    }
}