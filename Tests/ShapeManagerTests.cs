using Exceptions;
using FluentAssertions;
using ShapeSquareCalculator.Implementation;
using ShapeSquareCalculator.Implementation.Shapes;

namespace Tests;

public class ShapeManagerTests
{
    [Fact]
    public void TestThrowShapeNotLoadedException()
    {
        var shapeManager = new ShapeManager();

        shapeManager.LoadShape(null);

        shapeManager.Invoking(x => x.GetSquare()).Should().Throw<ShapeNotLoadedException>()
            .WithMessage("Something went wrong, I didn't load your shape");
    }

    [Fact]
    public void TestThrowShapeNotValidException()
    {
        var shapeManager = new ShapeManager();
        var shape = new Circle(-5);

        shapeManager.LoadShape(shape);

        shapeManager.Invoking(x => x.GetSquare()).Should().Throw<ShapeNotValidException>()
            .WithMessage("Something went wrong, Your shape is invalid");
    }

    [Fact]
    public void TestCorrectLoadShape()
    {
        var shapeManager = new ShapeManager();
        var shape = new Circle(-5);

        shapeManager.LoadShape(shape);

        shapeManager.GetShape().Should().Be(shape);
    }

    [Fact]
    public void TestCorrectCalculateSquare()
    {
        var shapeManager = new ShapeManager();
        var shape = new Triangle(3,4,5);
        var exceptedSquare = 6;

        shapeManager.LoadShape(shape);


        shapeManager.GetSquare().Should().Be(exceptedSquare);
    }
}