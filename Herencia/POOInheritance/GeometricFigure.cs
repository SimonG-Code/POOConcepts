namespace POOInheritance;

public abstract class GeometricFigure
{
    public string Name { get; set; }

    public double GetArea()
    {
        return 0;
    }

    public double GetPerimeter()
    {
        return 0;
    }

    public override string ToString()
    {
        return $"{Name}\n=> Area.....: {GetArea():F5} Perimeter: {GetPerimeter():F5}";
    }
}
 