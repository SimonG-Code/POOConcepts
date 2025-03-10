namespace POOInheritance;

public class Trapeze : GeometricFigure
{
    private double _base1;
    private double _base2;
    private double _height;
    private double _side1;
    private double _side2;

    public Trapeze(string name, double base1, double base2, double height, double side1, double side2)
    {
        Name = name;
        Base1 = base1;
        Base2 = base2;
        Height = height;
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

    public double Height
    {
        get { return _height; }
        set { _height = ValidateHeight(value); }
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
        return (_base1 + _base2) * _height / 2;
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

    private double ValidateHeight(double height)
    {
        if (height <= 0)
        {
            throw new ArgumentException("La altura debe ser positiva.");
        }
        return height;
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
        return $"{Name}\n=> Area.....: {GetArea():F5} Perimeter: {GetPerimeter():F5}";
    }
}
