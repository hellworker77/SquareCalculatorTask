using Exceptions;
using ShapeSquareCalculator.Abstractions;

namespace ShapeSquareCalculator.Implementation;

public class ShapeManager : IShapeManager
{
    private IShape? _shape;

    public void LoadShape(IShape? shape)
    {
        _shape = shape;
    }

    public double GetSquare()
    {
        if (_shape == null)
        {
            throw new ShapeNotLoadedException("Something went wrong, I didn't load your shape");
        }

        if (_shape.IsValid() == false)
        {
            throw new ShapeNotValidException("Something went wrong, Your shape is invalid");
        }

        var square = _shape.GetSquare();

        return square;
    }

    public IShape? GetShape()
    {
        return _shape;
    }
}