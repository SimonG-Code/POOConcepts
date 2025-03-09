﻿using System.Reflection.Metadata.Ecma335;

namespace POOInheritance;

public class Square : GeometricFigure
{
    private double _side;

    public Square(string name, double side)
    {
        Name = name;
        Side = side;
    }

    public double Side
    {
        get { return _side; }
        set { _side = ValidateSide(value); }
    }

    public double GetArena()
    {
        return _side * _side;
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

    public override string ToString()
    {
        return $"{Name}\n=> Area.....: {GetArea():F5} Perimeter: {GetPerimeter():F5}";
    }
}
