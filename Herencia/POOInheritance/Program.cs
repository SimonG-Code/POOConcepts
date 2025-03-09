using POOInheritance;

public class Program
{
    public static void Main()
    {
        try
        {
            var figures = new List<GeometricFigure>
            {
                new Circle("Circle", 5),
                new Square("Square", 10),
                new Rhombus("Rhombus", 5, 7, 10),
                new Kite("Kite", 7, 8, 5, 6),
                new Rectangle("Rectangle", 4.568, 67.79),
                new Parallelogram("Parallelogram", 14.65, 54.67, 23.09),
                new Triangle("Triangle", 45.56, 12.34, 27.09, 15),
                new Trapeze("Trapeze", 10, 20, 30, 40, 20)
            };

            foreach (var figure in figures)
            {
                Console.WriteLine(figure);
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}