namespace POOInheritance;

public class Kite : GeometricFigure
{
    private double _sideA;
    private double _sideB;
    private double _d1;
    private double _d2;

    public Kite(string name, double sideA, double sideB, double d1, double d2)
    {
        Name = name;
        SideA = sideA;
        SideB = sideB;
        D1 = d1;
        D2 = d2;
    }

    public double SideA
    {
        get { return _sideA; }
        set { _sideA = ValidateSideA(value); }
    }

    public double SideB
    {
        get { return _sideB; }
        set { _sideB = ValidateSideB(value); }
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
        return 2 * (_sideA + _sideB);
    }

    private double ValidateSideA(double sideA)
    {
        if (sideA <= 0)
        {
            throw new ArgumentException("El lado A debe ser positivo.");
        }
        return sideA;
    }

    private double ValidateSideB(double sideB)
    {
        if (sideB <= 0)
        {
            throw new ArgumentException("El lado B debe ser positivo.");
        }
        return sideB;
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
