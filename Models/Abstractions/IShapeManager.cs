namespace ShapeSquareCalculator.Abstractions;

public interface IShapeManager
{
    public void LoadShape(IShape shape);
    public double GetSquare();
    public IShape GetShape();
}