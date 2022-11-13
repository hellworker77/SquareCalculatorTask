namespace Exceptions;

public class ShapeNotValidException : Exception
{
    public ShapeNotValidException(string message) : base(message)
    {
    }

    public ShapeNotValidException()
    {
        
    }
}