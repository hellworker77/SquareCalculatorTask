using Exceptions;
using ShapeSquareCalculator.Abstractions;

namespace ShapeSquareCalculator.Implementation;

public class View : IView
{
    public void Print(IShapeManager shapeManager)
    {
        try
        {
            var square = shapeManager.GetSquare();
            var shapeInfo = shapeManager.GetShape();

            Console.WriteLine($"{shapeInfo} \n\tsquare: {square}");
        }
        catch (ShapeNotValidException shapeNotValidException)
        {
            ExceptionHandle(shapeNotValidException);
        }
        catch (ShapeNotLoadedException shapeNotLoadedException)
        {
            ExceptionHandle(shapeNotLoadedException);
        }
    }

    private void ExceptionHandle(ShapeNotValidException shapeNotValidException)
    {
        Console.WriteLine(shapeNotValidException.Message);
    }
    private void ExceptionHandle(ShapeNotLoadedException shapeNotLoadedException)
    {
        Console.WriteLine(shapeNotLoadedException.Message);
    }
}