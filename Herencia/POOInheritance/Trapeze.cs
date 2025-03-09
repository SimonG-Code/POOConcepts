namespace POOInheritance;

public class Trapeze : GeometricFigure
{
    private double _base1;
    private double _base2;
    private double _h;
    private double _side1;
    private double _side2;

    public Trapeze(string name, double base1, double base2, double h, double side1, double side2)
    {
        Name = name;
        Base1 = base1;
        Base2 = base2;
        H = h;
        Side1 = side1;
        Side2 = side2;
    }

    public double Base1
    {
        get { return _base1; }
        set { _base1 = ValidateBase1(value); }
    }

    public double Base2
    {
        get { return _base2; }
        set { _base2 = ValidateBase2(value); }
    }

    public double H
    {
        get { return _h; }
        set { _h = ValidateH(value); }
    }

    public double Side1
    {
        get { return _side1; }
        set { _side1 = ValidateSide1(value); }
    }

    public double Side2
    {
        get { return _side2; }
        set { _side2 = ValidateSide2(value); }
    }

    public double GetArea()
    {
        return (_base1 + _base2) * _h / 2;
    }

    public double GetPerimeter()
    {
        return _base1 + _base2 + _side1 + _side2;
    }

    private double ValidateBase1(double base1)
    {
        if (base1 <= 0)
        {
            throw new ArgumentException("La base 1 debe ser positiva.");
        }
        return base1;
    }

    private double ValidateBase2(double base2)
    {
        if (base2 <= 0)
        {
            throw new ArgumentException("La base 2 debe ser positiva.");
        }
        return base2;
    }

    private double ValidateH(double h)
    {
        if (h <= 0)
        {
            throw new ArgumentException("La altura debe ser positiva.");
        }
        return h;
    }

    private double ValidateSide1(double side1)
    {
        if (side1 <= 0)
        {
            throw new ArgumentException("El lado 1 debe ser positivo.");
        }
        return side1;
    }

    private double ValidateSide2(double side2)
    {
        if (side2 <= 0)
        {
            throw new ArgumentException("El lado 2 debe ser positivo.");
        }
        return side2;
    }

    public override string ToString()
    {
        return $"{Name}\n=> Área: {GetArea():F5} Perímetro: {GetPerimeter():F5}";
    }
}
    