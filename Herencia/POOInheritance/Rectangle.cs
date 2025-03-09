namespace POOInheritance;

public class Rectangle : GeometricFigure
{
    private double _l;
    private double _w;

    public Rectangle(string name, double l, double w)
    {
        Name = name;
        L = l;
        W = w;
    }

    public double L
    {
        get { return _l; }
        set { _l = ValidateL(value); }
    }

    public double W
    {
        get { return _w; }
        set { _w = ValidateW(value); }
    }

    public double GetArea()
    {
        return _l * _w;
    }

    public double GetPerimeter()
    {
        return 2 * (_l + _w);
    }

    private double ValidateL(double l)
    {
        if (l <= 0)
        {
            throw new ArgumentException("La longitud debe ser positiva.");
        }
        return l;
    }

    private double ValidateW(double w)
    {
        if (w <= 0)
        {
            throw new ArgumentException("El ancho debe ser positivo.");
        }
        return w;
    }

    public override string ToString()
    {
        return $"{Name}\n=> Área: {GetArea():F5} Perímetro: {GetPerimeter():F5}";
    }
}