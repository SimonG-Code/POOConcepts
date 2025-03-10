namespace POOInheritance;
public class Triangle : GeometricFigure
{
    private double _sideA;
    private double _sideB;
    private double _sideC;
    private double _h;

    public Triangle(string name, double sideA, double sideB, double sideC, double h)
    {
        Name = name;
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
        H = h;
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

    public double SideC
    {
        get { return _sideC; }
        set { _sideC = ValidateSideC(value); }
    }

    public double H
    {
        get { return _h; }
        set { _h = ValidateH(value); }
    }

    public double GetArea()
    {
        return (_sideA * _h) / 2;
    }

    public double GetPerimeter()
    {
        return _sideA + _sideB + _sideC;
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

    private double ValidateSideC(double sideC)
    {
        if (sideC <= 0)
        {
            throw new ArgumentException("El lado C debe ser positivo.");
        }
        return sideC;
    }

    private double ValidateH(double h)
    {
        if (h <= 0)
        {
            throw new ArgumentException("La altura debe ser positiva.");
        }
        return h;
    }

    public override string ToString()
    {
        return $"{Name}\n=> Área: {GetArea():F5} Perímetro: {GetPerimeter():F5}";
    }
}