﻿var numberString = string.Empty;


do
{
    Console.Write("Ingrese un número entero o presione Ctrl + C para salir: ");
    var numberString = Console.ReadLine();
    var numberInt = 0;
    if  (int.TryParse(numberString, out numberInt!))

        if (numberInt % 2 == 0)
        {
        Console.WriteLine($"El número {numberInt}, es par.");
        }
        else
        {
        Console.WriteLine($"El número {numberInt}, es impar.");
        }
    else
    {
        Console.WriteLine($"Lo que ingresaste: {numberString}, no es un número entero.");
    }
} while (numberString != "S");

