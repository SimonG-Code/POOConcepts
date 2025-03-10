namespace POOInheritance;

public abstract class GeometricFigure
{
    public string Name { get; set; }

    public static double GetArea() => 0;

    public static double GetPerimeter() => 0;


    public override string ToString()
    {
        return $"{Name}\n=> Area.....: {GetArea():F5} Perimeter: {GetPerimeter():F5}";
    }
}

