namespace POOInheritance;

public class Rhombus : GeometricFigure
{
    private double _side;
    private double _d1;
    private double _d2;

    public Rhombus(string name, double side, double d1, double d2)
    {
        Name = name;
        Side = side;
        D1 = d1;
        D2 = d2;
    }
    public double Side
    {
        get { return _side; }
        set { _side = ValidateSide(value); }
    }
        

    public double D1 
    {
        get { return _d1; } 
        set { _d1 = ValidateD1(value); }
    }
    public double D2 
    { 
        get { return _d2; }
        set { _d2 = ValidateD2(value); }
    }

    public double GetArea()
    {
        return (_d1 * _d2) / 2;
    }

    public double GetPerimeter()
    {
        return 4 * _side;
    }

    private double ValidateSide(double side)
    {
        if (side <= 0)
        {
            throw new ArgumentException("El lado debe ser positivo.");
        }
        return side;
    }

    private double ValidateD1(double d1)
    {
        if (d1 <= 0)
        {
            throw new ArgumentException("La diagonal 1 debe ser positiva.");
        }
        return d1;
    }

    private double ValidateD2(double d2)
    {
        if (d2 <= 0)
        {
            throw new ArgumentException("La diagonal 2 debe ser positiva.");
        }
        return d2;
    }

    public override string ToString()
    {
        return $"{Name}\n=> Área: {GetArea():F5} Perímetro: {GetPerimeter():F5}";
    }
}