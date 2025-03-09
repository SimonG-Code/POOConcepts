namespace POOInheritance;

public class Circle : GeometricFigure
{
    private double _r;

    public Circle(string name, double r)
    {
        Name = name;
        R = r; 
    }

    public double R
    {
        get { return _r; }
        set { _r = ValidateR(value); }
    }
    public double GetArea()
    {
        return Math.PI * _r * _r;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * _r;

    }

    private double ValidateR(double r)
    {
        if (r <=0)
        {
            throw new ArgumentException("El radio debe ser positivo.");
        }
        return r; 
    }
    public override string ToString()
    {
        return $"{Name}\n=> Area.....: {GetArea():F5} Perimeter: {GetPerimeter():F5}";
    }
}
