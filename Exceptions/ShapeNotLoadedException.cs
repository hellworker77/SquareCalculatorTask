namespace Exceptions;

public class ShapeNotLoadedException : Exception
{
    public ShapeNotLoadedException(string message) : base(message)
    {
        
    }
    public ShapeNotLoadedException() : base()
    {

    }
}