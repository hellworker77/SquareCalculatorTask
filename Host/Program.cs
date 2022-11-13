using Host.CustomShapes;
using ShapeSquareCalculator.Abstractions;
using ShapeSquareCalculator.Implementation;
using ShapeSquareCalculator.Implementation.Shapes;

namespace Host;
public class Program
{
    private static IView _view;
    private static IShapeManager _shapeManager;
    private static IShape _shape;

    private static void Main(string[] args)
    {
        _view = new View();
        _shapeManager = new ShapeManager();

        _shape = new Triangle(5,4, 3);

        _shapeManager.LoadShape(_shape);
        
        _view.Print(_shapeManager);
    }
}