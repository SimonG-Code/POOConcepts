namespace POOInheritance;
public class Parallelogram : GeometricFigure
{
    private double _b;
    private double _h;
    private double _side;

    public Parallelogram(string name, double b, double h, double side)
    {
        Name = name;
        B = b;
        H = h;
        Side = side;
    }

    public double B
    {
        get { return _b; }
        set { _b = ValidateB(value); }
    }

    public double H
    {
        get { return _h; }
        set { _h = ValidateH(value); }
    }

    public double Side
    {
        get { return _side; }
        set { _side = ValidateSide(value); }
    }

    public double GetArea()
    {
        return _b * _h;
    }

    public double GetPerimeter()
    {
        return 2 * (_b + _side);
    }

    private double ValidateB(double b)
    {
        if (b <= 0)
        {
            throw new ArgumentException("La base debe ser positiva.");
        }
        return b;
    }

    private double ValidateH(double h)
    {
        if (h <= 0)
        {
            throw new ArgumentException("La altura debe ser positiva.");
        }
        return h;
    }

    private double ValidateSide(double side)
    {
        if (side <= 0)
        {
            throw new ArgumentException("El lado debe ser positivo.");
        }
        return side;
    }

    public override string ToString()
    {
        return $"{Name}\n=> Área: {GetArea():F5} Perímetro: {GetPerimeter():F5}";
    }
}